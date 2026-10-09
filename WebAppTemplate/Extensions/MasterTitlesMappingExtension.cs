using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterTitlesMappingExtension
    {
        public static MasterTitles ToModel(this MasterTitlesViewModel model)
        {
            return new MasterTitles
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Title = model.Title,
                Keyword = model.Keyword,
            };

        }
        public static MasterTitlesViewModel ToViewModel(this MasterTitles model)
        {
            return new MasterTitlesViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Title = model.Title,
                Keyword = model.Keyword,
            };

        }
        public static List<MasterTitlesViewModel> ToViewModelList(this List<MasterTitles> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterTitles> ToViewModelList(this List<MasterTitlesViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
