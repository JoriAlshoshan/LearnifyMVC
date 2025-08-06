using Asp.NetCoreMVCIntro.Context;
using Asp.NetCoreMVCIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.NetCoreMVCIntro.Repository;

public class ArticleRepository : IArticleRepository
{
	private readonly TutorialDbContext _context;

    public ArticleRepository(TutorialDbContext context)
    {
        _context = context;	
    }
	public async Task AddArticle(Article article)
	{
		_context.Articles.Add(article);
		await _context.SaveChangesAsync();
	}

	public Article DeleteArticle(int Id)
	{
		throw new NotImplementedException();
	}

	public async Task<IEnumerable<Article>> GetAllArticle()
	{
		return await _context.Articles.ToListAsync();
	}


	public Article GetArticle(int Id)
	{
		throw new NotImplementedException();
	}
	public async Task<IEnumerable<Tutorial>> GetAllTutorial()
	{
		return await _context.Tutorials.ToListAsync();
	}
	public async Task<IEnumerable<Article>> GetArticlesByTutorialId(int tutorialId)
	{
		return await _context.Articles
			.Where(a => a.TutorialId == tutorialId)
			.ToListAsync();
	}


	public Article UpdateArticle(Article article)
	{
		throw new NotImplementedException();
	}
}
