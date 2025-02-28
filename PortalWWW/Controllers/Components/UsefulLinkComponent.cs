﻿using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Components
{
    public class UsefulLinkComponent : ViewComponent
    {
        private readonly DatabaseAPIContext context;

        public UsefulLinkComponent(DatabaseAPIContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("UsefulLinkComponent", await context.UsefulLink.OrderBy(item => item.Position).ToListAsync());
        }
    }
}
