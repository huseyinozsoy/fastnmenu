using System.Collections.Generic;
using FastnMenu.Models;

namespace FastnMenu.DTOs
{
    public class MenuDTO
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ShortDescription { get; set; }
        public string Explanation { get; set; }
        public string Picture { get; set; }
        public double Discount { get; set; }
        public IEnumerable<Category> MenuCategories { get; set; }
    }
}