using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterPortfolioMappingExtension
    {
        public static MasterPortfolio ToModel(this MasterPortfolioViewModel model)
        {
            return new MasterPortfolio
            {
                IsActive = model.IsActive,
                Id = model.Id,
                CategoryId = model.CategoryId,
                Title = model.Title,
                ThumbnailImageURL = model.ThumbnailImageURL,
                ViewImageURL = model.ViewImageURL,


            };

        }
        public static MasterPortfolioViewModel ToViewModel(this MasterPortfolio model)
        {
            return new MasterPortfolioViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                CategoryId = model.CategoryId,
                MasterCategory = model.MasterCategory?.Name,
                Title = model.Title,
                ThumbnailImageURL = model.ThumbnailImageURL,
                ViewImageURL = model.ViewImageURL,
            };

        }
        public static List<MasterPortfolioViewModel> ToViewModelList(this List<MasterPortfolio> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterPortfolio> ToViewModelList(this List<MasterPortfolioViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
