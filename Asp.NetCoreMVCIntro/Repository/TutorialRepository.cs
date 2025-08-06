using Asp.NetCoreMVCIntro.Context;
using Asp.NetCoreMVCIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.NetCoreMVCIntro.Repository;

public class TutorialRepository : ITutorialRepository
{
	public readonly TutorialDbContext _context;

	public TutorialRepository(TutorialDbContext context)
    {
		_context = context;
	}

	public Tutorial Add(Tutorial tutorial)
	{
		_context.Tutorials.Add(tutorial);
		_context.SaveChanges();
		return tutorial;
	}

	public Tutorial Delete(int Id)
	{
		Tutorial tutorial = _context.Tutorials.Find(Id);
		if (tutorial != null)
		{
			_context.Tutorials.Remove(tutorial);
			_context.SaveChanges();
		}
		return tutorial;
	}

	public async Task <IEnumerable<Tutorial>> GetAllTutorial()
	{
		return await _context.Tutorials.ToListAsync();
    }

	public async Task <Tutorial> GetTutorial(int Id)
	{
		return  await _context.Tutorials.FindAsync(Id);
	}

	public Tutorial Update(Tutorial tutorialModified)
	{   
		_context.Update(tutorialModified);
		_context.SaveChanges();
		return tutorialModified;
	}
}
