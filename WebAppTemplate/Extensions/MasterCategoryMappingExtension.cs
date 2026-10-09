using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterCategoryMappingExtension
    {
        public static MasterCategory ToModel(this MasterCategoryViewModel model)
        {
            return new MasterCategory
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                Icon = model.Icon,


            };

        }
        public static MasterCategoryViewModel ToViewModel(this MasterCategory model)
        {
            return new MasterCategoryViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                Icon = model.Icon,
            };

        }
        public static List<MasterCategoryViewModel> ToViewModelList(this List<MasterCategory> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterCategory> ToViewModelList(this List<MasterCategoryViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
