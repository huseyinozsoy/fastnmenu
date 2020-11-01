using System.Collections.Generic;
using System.Threading.Tasks;
using FastnMenu.DTOs;

namespace FastnMenu.Core
{
    public interface ICompanyRepository
    {
        Task<List<CompanyMenuType>> GetCompanyWithMenuAndType();
        Task<List<CompanyMenuType>> GetCompanyWithMenuWithTypeByQrCode(string QrCode);
        Task<List<CompanyMenuType>> GetCompanyWithQrAndCategoryId(string QrCode, int CategoryId);
    }
}