using System.Collections.Generic;
using System.Threading.Tasks;
using FastnMenu.Core;
using FastnMenu.DTOs;
using FastnMenu.Repositories;

namespace FastnMenu.Services
{
    public class CompanyService:ICompanyService
    {
        private ICompanyRepository _repo;
        public CompanyService(ICompanyRepository repo)
        {
            _repo = repo;
        }
        public async Task<List<CompanyMenuType>> GetCompanyWithMenuAndType()
        {
            return await _repo.GetCompanyWithMenuAndType();
        }

        public async Task<CompanyMenuType> GetCompanyWithMenuWithTypeByQrCode(string QrCode)
        {
            return await _repo.GetCompanyWithMenuWithTypeByQrCode(QrCode);
        }

        public async Task<List<CompanyMenuType>> GetCompanyWithQrAndCategoryId(string QrCode, int CategoryId)
        {
            return await _repo.GetCompanyWithQrAndCategoryId(QrCode,CategoryId);
        }
        
    }
}