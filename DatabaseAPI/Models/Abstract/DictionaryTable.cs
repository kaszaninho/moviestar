using System.ComponentModel.DataAnnotations;

namespace DatabaseAPI.Models.Abstract
{
    public class DictionaryTable : BaseDatatable
    {
        public string? Name { get; set; }
        public string? Description { get; set; }  
    }
}
