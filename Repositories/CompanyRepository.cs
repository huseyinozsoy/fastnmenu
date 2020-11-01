using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastnMenu.Core;
using FastnMenu.DTOs;
using FastnMenu.Models;
using Microsoft.EntityFrameworkCore;

namespace FastnMenu.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private FastNMenuContext _context;
        public CompanyRepository(FastNMenuContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<CompanyMenuType>> GetCompanyWithMenuAndType()
        {
            return await _context.Companies.Include(m => m.Menus).Include(t => t.CompanyType).Select(s => new CompanyMenuType
            {
                Id = s.Id,
                Address = s.Address,
                Menus = s.Menus.Select(m => new MenuDTO
                {
                    Name = m.Name,
                    Price = m.Price,
                    ShortDescription = m.ShortDescription,
                    Explanation = m.Explanation,
                    Picture = m.Picture,
                    MenuCategories = m.Categories.ToList()
                }).ToList(),
                CompanyTypeName = s.CompanyType.TypeName,
                CompanyName = s.CompanyName,
                Description = s.Description,
                Email = s.Email,
                IsActive = s.IsActive,
                Phone = s.Phone,
                Picture = s.Picture,
                QRCode = s.QRCode,
                WorkHour = s.WorkHour
            }).ToListAsync();
        }

        public async Task<CompanyMenuType> GetCompanyWithMenuWithTypeByQrCode(string QrCode)
        {

            return await _context.Companies.Include(m => m.Menus).ThenInclude(x => x.Categories)
            .Where(x => x.QRCode == QrCode)
            .Select(s => new CompanyMenuType
            {
                Id = s.Id,
                Address = s.Address,
                Menus = s.Menus.Select(s => new MenuDTO
                {

                    Name = s.Name,
                    Discount = s.Discount,
                    Picture = s.Picture,
                    Price = s.Price,
                    ShortDescription = s.ShortDescription,
                    Explanation = s.Explanation,
                    MenuCategories = s.Categories.ToList()

                }).ToList(),
                CompanyTypeName = s.CompanyType.TypeName,
                CompanyName = s.CompanyName,
                Description = s.Description,
                Email = s.Email,
                IsActive = s.IsActive,
                Phone = s.Phone,
                Picture = s.Picture,
                QRCode = s.QRCode,
                WorkHour = s.WorkHour
            }).FirstOrDefaultAsync();
        }

        public async Task<List<CompanyMenuType>> GetCompanyWithQrAndCategoryId(string QrCode, int CategoryId)
        {
            return await _context.Menus.Include(m => m.Categories).Include(t => t.Company)
            .Where(x => x.Company.QRCode == QrCode && x.Categories.Select(c => c.Id == CategoryId).First())
            .Select(s => new CompanyMenuType
            {
                Id = s.Id,
                Address = s.Company.Address,
                Menus = new List<MenuDTO>{ new MenuDTO{
                        Name = s.Name,
                        Price = s.Price,
                        ShortDescription = s.ShortDescription,
                        Explanation = s.Explanation,
                        Picture = s.Picture,
                        Discount = s.Discount,
                        MenuCategories = s.Categories.ToList()
                    }
                },
                CompanyTypeName = s.Company.CompanyType.TypeName,
                CompanyName = s.Company.CompanyName,
                Description = s.Company.Description,
                Email = s.Company.Email,
                IsActive = s.Company.IsActive,
                Phone = s.Company.Phone,
                Picture = s.Company.Picture,
                QRCode = s.Company.QRCode,
                WorkHour = s.Company.WorkHour
            }).ToListAsync();
        }
    }
}