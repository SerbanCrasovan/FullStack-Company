using BackEndCompany.Data;
using BackEndCompany.DTOs;
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
        public List<GetCompanyModel> GetAllCompanies()
        {
            return context.Companies.Select(x => new GetCompanyModel { 
                Id = x.Id, Name = x.Name, 
                NbOfComments = context.Comments.Where(y => y.CompanyId == x.Id).Count() }).ToList();
        }
        ~CompanyService()
        {
            context?.Dispose();
        }
    }
}
