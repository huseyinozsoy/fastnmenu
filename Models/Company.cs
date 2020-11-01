using System;
using System.Collections.Generic;

namespace FastnMenu.Models
{
    public class Company
    {
        public int Id { get; set; }
        public int CompanyTypeId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string WorkHour { get; set; }
        public bool IsActive { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
        public DateTime SubscriptionExpiryDate { get; set; }
        public string QRCode { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public CompanyType CompanyType { get; set; }
    }
}