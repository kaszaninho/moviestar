using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CMS
{
    public class Navbar : AbstractCMSDatatable
    {
        public string? Controller { get; set; }
        public string? Action { get; set; }
    }
}
