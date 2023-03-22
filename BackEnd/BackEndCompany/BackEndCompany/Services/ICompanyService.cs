using BackEndCompany.Models;

namespace BackEndCompany.Services
{
    public interface ICompanyService
    {
        List<Company> GetAllCompanies();
    }
}
