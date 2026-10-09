using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterExperienceMappingExtension
    {
        public static MasterExperience ToModel(this MasterExperienceViewModel model)
        {
            return new MasterExperience
            {
                IsActive = model.IsActive,
                Id = model.Id,
                StartYear = model.StartYear,
                EndYear = model.EndYear,
                CompanyName = model.CompanyName,
                Title = model.Title,
                Desc = model.Desc,

            };

        }
        public static MasterExperienceViewModel ToViewModel(this MasterExperience model)
        {
            return new MasterExperienceViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                StartYear = model.StartYear,
                EndYear = model.EndYear,
                CompanyName = model.CompanyName,
                Title = model.Title,
                Desc = model.Desc,
            };

        }
        public static List<MasterExperienceViewModel> ToViewModelList(this List<MasterExperience> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterExperience> ToViewModelList(this List<MasterExperienceViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
