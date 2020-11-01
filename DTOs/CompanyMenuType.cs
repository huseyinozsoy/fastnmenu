using System;
using System.Collections.Generic;
using FastnMenu.Models;

namespace FastnMenu.DTOs
{
    public class CompanyMenuType
    {
        public int Id { get; set; }
        public string CompanyTypeName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string WorkHour { get; set; }
        public bool IsActive { get; set; }
        public string QRCode { get; set; }
        public List<MenuDTO> Menus { get; set; }
    }
}