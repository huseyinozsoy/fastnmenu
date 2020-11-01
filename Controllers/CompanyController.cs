using System.Collections.Generic;
using System.Threading.Tasks;
using FastnMenu.DTOs;
using FastnMenu.Services;
using Microsoft.AspNetCore.Mvc;

namespace FastnMenu.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController:ControllerBase
    {
        private ICompanyService _service;
        public CompanyController(ICompanyService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IEnumerable<CompanyMenuType>> Get()
        {
            return await _service.GetCompanyWithMenuAndType();
        }
        [HttpGet("{id}")]
        public async Task<List<CompanyMenuType>> Get(string id)
        {
            return await _service.GetCompanyWithMenuWithTypeByQrCode(id);
        }
        
        [HttpGet("{Qrcode}/category/{id}")]
        public async Task<List<CompanyMenuType>> Get(string Qrcode, int id)
        {
            return await _service.GetCompanyWithQrAndCategoryId(Qrcode,id);
        }
        

    }
}