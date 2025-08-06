using Asp.NetCoreMVCIntro.Models;

namespace Asp.NetCoreMVCIntro.Repository;

public interface IArticleRepository
{
	Task AddArticle(Article article);

	Article UpdateArticle(Article article);

	Article DeleteArticle(int Id);

	Article GetArticle(int Id);
	Task<IEnumerable<Tutorial>> GetAllTutorial();

	Task<IEnumerable<Article>> GetAllArticle(); 

	Task<IEnumerable<Article>> GetArticlesByTutorialId(int tutorialId);

}

