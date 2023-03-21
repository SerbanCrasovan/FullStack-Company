using BackEndCompany.Models;

namespace BackEndCompany.Services
{
    public interface ICompanyService
    {
        List<Comment> GetAllComment();

        void UpdateC(int id, Company newCompany);
    
        void DeleteCompany
    }
}
