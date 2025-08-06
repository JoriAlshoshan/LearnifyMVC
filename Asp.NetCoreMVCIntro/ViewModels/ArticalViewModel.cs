using Asp.NetCoreMVCIntro.Migrations;
using Asp.NetCoreMVCIntro.Models;
using System.ComponentModel.DataAnnotations;

namespace Asp.NetCoreMVCIntro.ViewModels;

public class ArticalViewModel
{
    public ArticalViewModel()
    {
        tutorials = new List<Tutorial>();
    }

    [Required(ErrorMessage ="please enter article Title")]
    [Display(Name ="please emter the article title")]
    public string ArticleTitle { get; set; }

    [Required(ErrorMessage ="please enter article Content")]
    [Display(Name ="Write article ")]
    public string ArticleContent { get; set; }

    public int TutorialId { get; set; }

    public List <Tutorial> tutorials{ get; set; }   

}
