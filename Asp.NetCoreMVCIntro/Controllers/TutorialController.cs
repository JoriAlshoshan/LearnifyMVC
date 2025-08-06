using Asp.NetCoreMVCIntro.Models;
using Asp.NetCoreMVCIntro.Repository;
using Asp.NetCoreMVCIntro.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVCIntro.Controllers;

//[Route("Tutorial")]
public class TutorialController : Controller
{  
    private readonly ITutorialRepository _tutorialRepository;
    public TutorialController(ITutorialRepository tutorialRepository)
    {
		_tutorialRepository = tutorialRepository;
    }
    public async Task<IActionResult> Index()
    {
        var tutorials =await _tutorialRepository.GetAllTutorial();
        return View(tutorials);
    }
    
    [HttpGet]
    public IActionResult CreateTutorial()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateTutorial(Tutorial tutorial)
    {
        if (!ModelState.IsValid)
        {
            return View(tutorial);
        }
        Tutorial newTutorial = _tutorialRepository.Add(tutorial);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task <IActionResult > EditTutorial(int id, string querystringData)
     {
        Tutorial tutorial =  await _tutorialRepository.GetTutorial(id);
        return View(tutorial);
     }
    
    [HttpPost]
    public  async Task <IActionResult> EditTutorial(Tutorial modifiedData)
     {
        Tutorial tutorial = await _tutorialRepository.GetTutorial(modifiedData.Id);
        tutorial.Name = modifiedData.Name;
        tutorial.Description = modifiedData.Description;
        Tutorial updateTutorial= _tutorialRepository.Update(tutorial);
        return RedirectToAction("Index");
     }

    [HttpGet]
	public async Task<IActionResult> GetTutorial(int id)
	{
		Tutorial tutorial = await _tutorialRepository.GetTutorial(id);
        List<Tutorial> tutorials = new List<Tutorial>();
        tutorials.Add(tutorial);
		return View("Index",tutorials);
	}
	public IActionResult DeleteTutorial(int id)
     {
        Tutorial deletedTutorial = _tutorialRepository.Delete(id);
        return RedirectToAction("Index");
     }

    

}
