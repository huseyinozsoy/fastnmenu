using System.Collections.Generic;

namespace FastnMenu.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ShortDescription { get; set; }
        public string Picture { get; set; }
        public double Discount { get; set; }
        public string Explanation { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public Company Company { get; set; }
    }
}