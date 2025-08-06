using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Asp.NetCoreMVCIntro.Models;

public class Article
{
    public int ArticleId { get; set; }

    [Required(ErrorMessage ="Please enter article title")]
    public string ArticleTitle { get; set; }

	[Required(ErrorMessage = "Please enter article content")]
	public string ArticleContent{ get; set; }
    public int TutorialId { get; set; }
    public Tutorial Tutorial { get; set; }
}
