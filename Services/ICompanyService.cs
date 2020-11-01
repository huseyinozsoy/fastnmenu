using System.Collections.Generic;
using System.Threading.Tasks;
using FastnMenu.DTOs;

namespace FastnMenu.Services
{
    public interface ICompanyService
    {
        Task<List<CompanyMenuType>> GetCompanyWithMenuAndType();
        Task<CompanyMenuType> GetCompanyWithMenuWithTypeByQrCode(string QrCode);
        Task<List<CompanyMenuType>> GetCompanyWithQrAndCategoryId(string QrCode, int CategoryId);
    }
}