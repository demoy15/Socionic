using Socionic.DBContext;
using Socionic.Models;

namespace Socionic.Services;

public class QuestionService : IQuestionService
{
    private readonly SocionicContext _context;

    public QuestionService(SocionicContext context)
    {
        _context = context;
    }

    public async Task<List<Question>> GetAll()
    {
        
        return new List<Question>(_context.Set<Question>().Where(x => true));
    }

    public async Task<Question?> GetById(Guid id)
    {
        return await _context.Set<Question>().FindAsync(id);
    }
    
    
}