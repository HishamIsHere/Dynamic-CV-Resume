using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterServicesMappingExtension
    {
        public static MasterServices ToModel(this MasterServicesViewModel model)
        {
            return new MasterServices
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Icon = model.Icon,
                Name = model.Name,
                Desc = model.Desc,

            };

        }
        public static MasterServicesViewModel ToViewModel(this MasterServices model)
        {
            return new MasterServicesViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Icon = model.Icon,
                Name = model.Name,
                Desc = model.Desc,
            };

        }
        public static List<MasterServicesViewModel> ToViewModelList(this List<MasterServices> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterServices> ToViewModelList(this List<MasterServicesViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
