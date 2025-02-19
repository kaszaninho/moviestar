using BusinessLogic;
using DatabaseAPI.Data;
using DatabaseAPI.Models.People;
using DatabaseAPI.Repository;
using HelperProject;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using PortalWWW.Helpers;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.ViewLocationFormats.Add("/Views/Shared/AdminViewsTemplates/{0}.cshtml");
    foreach (var directory in Directory.GetDirectories("Views/Admin", "*", SearchOption.AllDirectories))
    {
        options.ViewLocationFormats.Add("/" + directory.Replace("\\", "/") + "/{0}.cshtml");
    }
});

var connectionString = builder.Configuration.GetConnectionString("DatabaseAPIContext") ?? throw new InvalidOperationException("Connection string 'DatabaseAPIContext' not found.");
builder.Services.AddDbContext<DatabaseAPIContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("Stripe"));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IEmailSender, EmailSender>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<DatabaseAPIContext>()
    .AddDefaultTokenProviders()
    .AddUserManager<UserManager<IdentityUser>>()
    .AddRoles<IdentityRole>();

builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
});

builder.Services.AddSession(options =>
{
    // Set a short timeout for easy testing.
    options.IdleTimeout = TimeSpan.FromSeconds(360);
    options.Cookie.HttpOnly = true;
    // Make the session cookie essential
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await CreateRolesAndAdmin(services);  // Ensure roles exist
}

app.UseHttpsRedirection();
app.UseStaticFiles();

StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();

app.UseRouting();

app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

async Task CreateRolesAndAdmin(IServiceProvider serviceProvider)
{
    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
    var dbContext = serviceProvider.GetRequiredService<DatabaseAPIContext>();

    string[] roleNames = { "Admin", "Client" };
    if (!roleManager.RoleExistsAsync(Constans.Role_Admin).GetAwaiter().GetResult())
    {
        roleManager.CreateAsync(new IdentityRole("Client")).GetAwaiter().GetResult();
        roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();

        //if roles are not created, then we will create admin user as well
        var country = await dbContext.Country.FirstOrDefaultAsync(item => item.Name == "Poland");
        if (country == null)
        {
            await dbContext.Country.AddAsync(new DatabaseAPI.Models.DictionaryModels.Country { CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now, Name = "Poland", IsActive = true });
            await dbContext.SaveChangesAsync();
            country = await dbContext.Country.FirstOrDefaultAsync(item => item.Name == "Poland");
        }

        var address = new DatabaseAPI.Models.General.Address()
        {
            StreetName = "Broniewskiego",
            City = "Nowy S¹cz",
            HouseNumber = 12,
            ApartmentNumber = 8,
            EirCode = "33-300",
            Country = country
        };

        var userLevel = await dbContext.UserLevel.FirstOrDefaultAsync();
        if (userLevel == null)
        {
            await dbContext.UserLevel.AddAsync(new UserLevel
            {
                Id = 1,
                CreatedAt = new DateTime(2025, 2, 2),
                ModifiedAt = new DateTime(2025, 2, 2),
                IsActive = true,
                Description = "Level 1",
                Name = "1",
                PointsToNextLevel = 10
            });
            await dbContext.SaveChangesAsync();
            userLevel = await dbContext.UserLevel.FirstOrDefaultAsync();
        }
        userManager.CreateAsync(new User()
        {
            UserName = "admin@admin.pl",
            Email = "admin@admin.pl",
            FirstName = "Bartosz",
            LastName = " Szortab",
            PhoneNumber = "505404393",
            Address = address,
            UserLevel = userLevel
        }, "Admin9#").GetAwaiter().GetResult();


        User user = dbContext.User.FirstOrDefault(u => u.Email == "admin@admin.pl");
        userManager.AddToRoleAsync(user, Constans.Role_Admin).GetAwaiter().GetResult();

        foreach (var roleName in roleNames)
        {
            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }
    }
}