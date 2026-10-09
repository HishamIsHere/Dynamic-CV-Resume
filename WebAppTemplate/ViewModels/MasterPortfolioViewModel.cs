using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppTemplate.Models;

namespace WebAppTemplate.ViewModels
{
    public class MasterPortfolioViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        [Display(Name = "Category Id")]
        public string? MasterCategory { get; set; }
        public string ThumbnailImageURL { get; set; }
        public IFormFile ThumbnailImageFile { get; set; }
        public string ViewImageURL { get; set; }
        public IFormFile ViewImageFile { get; set; }
        public IEnumerable<SelectListItem> MasterCategoryList { get; set; }
    }
}
