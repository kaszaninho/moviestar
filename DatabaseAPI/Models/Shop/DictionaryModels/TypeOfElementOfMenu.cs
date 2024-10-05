using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CoffeeShop.DictionaryModels
{
    public class TypeOfElementOfMenu : DictionaryTable
    {
        public ICollection<ELementOfMenu> ELementOfMenus { get; set; }
    }
}
