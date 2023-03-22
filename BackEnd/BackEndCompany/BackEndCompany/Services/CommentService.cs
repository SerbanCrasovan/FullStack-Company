using BackEndCompany.Data;
using BackEndCompany.Models;
using Microsoft.EntityFrameworkCore;
using BackEndCompany.DTOs;

namespace BackEndCompany.Services
{
    public class CommentService : ICommentService
    {
        BackEndCompanyContext context;
        public CommentService()
        {
            context = new BackEndCompanyContext();
        }
        public void AddComment(Comment newComment)
        {

            context.Comments.Add(newComment);
            context.SaveChanges();
        }

        public void DeleteComment(int id)
        {
            throw new NotImplementedException();
        }

        public List<GetCommentModel> GetAllComments()
        {
            return context.Comments.Select(x => new GetCommentModel { Id = x.Id, Text = x.Text, CompanyId = x.CompanyId }).ToList();
        }

        public List<Comment> GetAllComments(int companyId)
        {
            return context.Comments.Where(n => n.CompanyId == companyId).ToList();
        }

        public void UpdateComment(int id, Comment newComment)
        {
            throw new NotImplementedException();
        }

        ~CommentService() 
        {
            context?.Dispose();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
