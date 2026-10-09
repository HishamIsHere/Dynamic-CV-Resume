using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppTemplate.Models;

namespace WebAppTemplate.ViewModels
{
    public class MasterPortfolioFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string ThumbnailImageURL { get; set; }
        public IFormFile ThumbnailImageFile { get; set; }
        public string ViewImageURL { get; set; }
        public IFormFile ViewImageFile { get; set; }
        public List<MasterPortfolioViewModel> List { get; set; } = new();
        public MasterPortfolioViewModel FormModel { get; set; } = new();
        public IEnumerable<SelectListItem> MasterCategoryList { get; set; } = new List<SelectListItem>();
    }
}
