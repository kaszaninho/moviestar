using DatabaseAPI.Models.Abstract;
using DatabaseAPI.Models.CoffeeShop.DictionaryModels;

namespace DatabaseAPI.Models.CoffeeShop
{
    public class ELementOfMenu : DictionaryTable
    {
        public TypeOfElementOfMenu TypeOfElementOfMenu { get; set; }
        public int TypeOfElementOfMenuId { get; set; }
        public decimal Price { get; set; }
    }
}
