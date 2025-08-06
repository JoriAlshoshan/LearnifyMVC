using Asp.NetCoreMVCIntro.Models;
using Asp.NetCoreMVCIntro.Repository;
using Asp.NetCoreMVCIntro.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Asp.NetCoreMVCIntro.Controllers
{
	public class ArticalController : Controller
	{
		private readonly IArticleRepository _articleRepository;

		public ArticalController(IArticleRepository articleRepository)
		{
			_articleRepository = articleRepository;
		}

		public async Task<IActionResult> Index()
		{
			IEnumerable<Article> articles = await _articleRepository.GetAllArticle();
			return View(articles);
		}


		[HttpGet]
		public async Task<IActionResult> AddNewArticle()
		{
			var tutorials = await _articleRepository.GetAllTutorial();
			ViewBag.Tutorials = new SelectList(tutorials, "Id", "Name");
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddArticle(ArticalViewModel model)
		{
			if (!ModelState.IsValid)
			{
				var tutorials = await _articleRepository.GetAllTutorial();
				ViewBag.Tutorials = new SelectList(tutorials, "Id", "Name");
				return View("AddNewArticle", model);
			}

			var article = new Article
			{
				ArticleTitle = model.ArticleTitle,
				ArticleContent = model.ArticleContent,
				TutorialId = model.TutorialId
			};

			await _articleRepository.AddArticle(article);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> DisplayArticlies(int id)
		{
			IEnumerable<Article> articles = await _articleRepository.GetArticlesByTutorialId(id);
			return View(articles);
		}
	}
}
