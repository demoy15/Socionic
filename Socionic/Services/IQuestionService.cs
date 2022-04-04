using Socionic.Models;

namespace Socionic.Services;

public interface IQuestionService
{
    public Task<List<Question>> GetAll();
    public Task<Question?> GetById(Guid id);
}