using Asp.NetCoreMVCIntro.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVCIntro.ViewComponents;

public class TutorialMenuViewComponent: ViewComponent
{
    private readonly ITutorialRepository _tutorialRepository;

    public TutorialMenuViewComponent(ITutorialRepository tutorialRepository)
    {
		_tutorialRepository = tutorialRepository;
	}

	public async Task<IViewComponentResult> InvokeAsync()
	{
		var tutorials = (await _tutorialRepository.GetAllTutorial()).OrderBy(p => p.Name);
		return View(tutorials);
	}

	
}
