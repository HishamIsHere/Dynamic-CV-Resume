using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterContactUsMappingExtension
    {
        public static MasterContactUs ToModel(this MasterContactUsViewModel model)
        {
            return new MasterContactUs
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Icon = model.Icon,
                Link = model.Link,
                Title = model.Title,
            };

        }
        public static MasterContactUsViewModel ToViewModel(this MasterContactUs model)
        {
            return new MasterContactUsViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Icon = model.Icon,
                Link = model.Link,
                Title = model.Title,
            };

        }
        public static List<MasterContactUsViewModel> ToViewModelList(this List<MasterContactUs> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterContactUs> ToViewModelList(this List<MasterContactUsViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
