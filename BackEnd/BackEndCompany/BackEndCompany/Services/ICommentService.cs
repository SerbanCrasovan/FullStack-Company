using BackEndCompany.DTOs;
using BackEndCompany.Models;

namespace BackEndCompany.Services
{
    public interface ICommentService
    {
        List<GetCommentModel> GetAllComments();

        void AddComment(Comment newComment);

        void UpdateComment(int id, Comment newComment);

        void DeleteComment(int id);


    }
}
