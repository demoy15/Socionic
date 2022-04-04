using Microsoft.AspNetCore.Mvc;
using Socionic.DBContext;
using Socionic.Models;
using Socionic.Services;

namespace Socionic.Controllers;


[Route("test")]
[ApiController]
public class QuestionController : ControllerBase
{
    private readonly IQuestionService _questionService;

    public QuestionController(IQuestionService questionService)
    {
        _questionService = questionService ?? throw new ArgumentNullException(nameof(questionService));
    }

    [HttpGet("{id}")]
    public async Task<Question?> GetQuestion(Guid id)
    {
        return await _questionService.GetById(id);
    }

    [HttpGet("")]
    public async Task<List<Question>> GetAllQuestions()
    {
        return await _questionService.GetAll();
    }


}