using BackEndCompany.Models;

namespace BackEndCompany.Services
{
    public interface ICommentService
    {
        List<Comment> GetAllComments();

        void AddComment(Comment newComment);

        void UpdateComment(int id, Company newCompany);

        void DeleteComment(int id);


    }
}
