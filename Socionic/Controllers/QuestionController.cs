using Microsoft.AspNetCore.Mvc;
using Socionic.Models;

namespace Socionic.Controllers;


[Route("test")]
[ApiController]
public class QuestionController : ControllerBase
{
    [HttpGet("{id}")]
    public Question GetQuestion(Guid id)
    {
        return new Question();
    }
    
    
}