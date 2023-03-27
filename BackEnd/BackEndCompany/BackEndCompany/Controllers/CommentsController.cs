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
            return Ok();
        }

        //Read all comments
        [HttpGet("All")]
        public IActionResult GetComments()
        {
            var allComments = _service.GetAllComments();
            return Ok(allComments);
        }
        //Read comments by id
        [HttpGet("{companyId:int}")]
        public IActionResult GetComments(int companyId) 
        {
            var allComments = _service.GetAllComments(companyId);
            return Ok(allComments);
        }

        // Update comment
        [HttpPut("UpdateComment/{id}")]
        public IActionResult UpdateComment(int id, [FromBody]EditCommentModel comment)
        {
            _service.UpdateComment(id, comment);
            return Ok(comment);
        }

        //Delete comment
        [HttpDelete("DeleteComment/{id}")]
        public IActionResult DeleteComment(int id)
        {
            _service.DeleteComment(id);
            return Ok();
        }
    }
}
