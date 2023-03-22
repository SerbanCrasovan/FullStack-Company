using BackEndCompany.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace BackEndCompany.Controllers
{
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private ICompanyService _service;

        public CompanyController(ICompanyService service)
        {
            _service = service;
        }

        //Read all companies
        [HttpGet("[action]")]

        public IActionResult GetCompanies()
        {
            var allCompanies = _service.GetAllCompanies();
            return Ok(allCompanies);
        }
    }
}
