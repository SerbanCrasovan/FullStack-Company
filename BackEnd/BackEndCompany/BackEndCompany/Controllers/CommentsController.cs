using BackEndCompany.DTOs;
using BackEndCompany.Models;
using BackEndCompany.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackEndCompany.Controllers
{
    [Route("api/[controller]")]
    public class CommentsController : Controller
    {
        private ICommentService _service;

        public CommentsController(ICommentService service)
        {
            _service = service;
        }

        //Create/Add new Comment
        [HttpPost("AddComment")]
        public IActionResult AddComment([FromBody]AddCommentModel comment)
        {
            _service.AddComment(new Comment { CompanyId = comment.CompanyId, Text = comment.Text});
            return Ok("Added");
        }

        //Read all comments
        [HttpGet("[action]")]
        public IActionResult GetComments()
        {
            var allComments = _service.GetAllComments();
            return Ok(allComments);
        }
    }
}
