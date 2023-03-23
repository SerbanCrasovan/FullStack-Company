using BackEndCompany.DTOs;
using BackEndCompany.Models;

namespace BackEndCompany.Services
{
    public interface ICompanyService
    {
        List<GetCompanyModel> GetAllCompanies();
    }
}
