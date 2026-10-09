using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterSkillsMappingExtension
    {
        public static MasterSkills ToModel(this MasterSkillsViewModel model)
        {
            return new MasterSkills
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                Percentage = model.Percentage,
                IsSoftSkill = model.IsSoftSkill,
                IsKnowledge = model.IsKnowledge,


            };

        }
        public static MasterSkillsViewModel ToViewModel(this MasterSkills model)
        {
            return new MasterSkillsViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                Percentage = model.Percentage,
                IsSoftSkill = model.IsSoftSkill,
                IsKnowledge = model.IsKnowledge,
            };

        }
        public static List<MasterSkillsViewModel> ToViewModelList(this List<MasterSkills> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterSkills> ToViewModelList(this List<MasterSkillsViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
