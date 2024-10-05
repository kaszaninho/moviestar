using System.ComponentModel.DataAnnotations;

namespace DatabaseAPI.Models.Abstract
{
    public class BaseDatatable
    {
        [Key]
        public int Id { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}