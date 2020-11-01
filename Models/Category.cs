using System.Collections.Generic;

namespace FastnMenu.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Menu> Menus { get; set; }
    }
}