using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterSocialMediaMappingExtension
    {
        public static MasterSocialMedia ToModel(this MasterSocialMediaViewModel model)
        {
            return new MasterSocialMedia
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Icon = model.Icon,
                Link = model.Link,

            };

        }
        public static MasterSocialMediaViewModel ToViewModel(this MasterSocialMedia model)
        {
            return new MasterSocialMediaViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Icon = model.Icon,
                Link = model.Link,
            };

        }
        public static List<MasterSocialMediaViewModel> ToViewModelList(this List<MasterSocialMedia> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterSocialMedia> ToViewModelList(this List<MasterSocialMediaViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
