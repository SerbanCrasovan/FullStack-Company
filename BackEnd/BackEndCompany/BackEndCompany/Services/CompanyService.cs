using BackEndCompany.Data;
using BackEndCompany.Models;

namespace BackEndCompany.Services
{
    public class CompanyService : ICompanyService
    {
        BackEndCompanyContext context;

        public CompanyService()
        {
            context = new BackEndCompanyContext();
        }
        public List<Company> GetAllCompanies()
        {
            return context.Companies.ToList();
        }
        ~CompanyService()
        {
            context?.Dispose();
        }
    }
}
