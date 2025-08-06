using Asp.NetCoreMVCIntro.Models;

namespace Asp.NetCoreMVCIntro.Repository;

public interface ITutorialRepository
{
	Tutorial Add(Tutorial tutorial);
	Tutorial Update(Tutorial tutorial);
	Tutorial Delete(int Id);
	Task<Tutorial> GetTutorial(int Id);
	Task<IEnumerable<Tutorial>> GetAllTutorial();

}
