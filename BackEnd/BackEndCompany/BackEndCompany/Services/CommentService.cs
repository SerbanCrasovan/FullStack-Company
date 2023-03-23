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
            var comment = context.Comments.FirstOrDefault(c => c.Id == id);
            context.Comments.Remove(comment);
            context.SaveChanges();
        }

        public List<GetCommentModel> GetAllComments()
        {
            return context.Comments.Select(x => new GetCommentModel { Id = x.Id, Text = x.Text, CompanyId = x.CompanyId }).ToList();
        }

        public List<GetCommentModel> GetAllComments(int companyId)
        {
            return context.Comments.Where(x => x.CompanyId == companyId).Select(
                x => new GetCommentModel { Id = x.Id, Text = x.Text, CompanyId = x.CompanyId }).ToList();
        }

        public void UpdateComment(int id, EditCommentModel newComment)
        {
            var oldComment = context.Comments.FirstOrDefault(x => x.Id == id);
            if(oldComment != null)
            {
                oldComment.Text = newComment.Text;
            }
            context.SaveChanges();
        }

        ~CommentService() 
        {
            context?.Dispose();
        }

    }
}
