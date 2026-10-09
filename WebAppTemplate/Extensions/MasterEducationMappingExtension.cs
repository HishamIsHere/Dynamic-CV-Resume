using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterEducationMappingExtension
    {
        public static MasterEducation ToModel(this MasterEducationViewModel model)
        {
            return new MasterEducation
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Year = model.Year,
                University = model.University,
                Title = model.Title,
                Desc = model.Desc,
            };

        }
        public static MasterEducationViewModel ToViewModel(this MasterEducation model)
        {
            return new MasterEducationViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Year = model.Year,
                University = model.University,
                Title = model.Title,
                Desc = model.Desc,
            };

        }
        public static List<MasterEducationViewModel> ToViewModelList(this List<MasterEducation> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterEducation> ToViewModelList(this List<MasterEducationViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
