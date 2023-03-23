using BackEndCompany.DTOs;
using BackEndCompany.Models;

namespace BackEndCompany.Services
{
    public interface ICommentService
    {
        List<GetCommentModel> GetAllComments();

        List<GetCommentModel> GetAllComments(int companyId);

        void AddComment(Comment newComment);

        void UpdateComment(int id, EditCommentModel newComment);

        void DeleteComment(int id);


    }
}
