using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp.NetCoreMVCIntro.Models;


public class Tutorial
{
    [Key] 
	public int Id { get; set; }

    [RegularExpression(@"^[a-zA-Z]+[a-zA-Z-_]*$", ErrorMessage = "Please Enter Text")]
    [Required]
    [Display(Name = "Tutorial Name")]
    public string Name { get; set; }

	[Required]
    [Display(Name= "Tutorial Description")]
	public string Description { get; set; }

    public List<Article> Articles { get; set; }

}
