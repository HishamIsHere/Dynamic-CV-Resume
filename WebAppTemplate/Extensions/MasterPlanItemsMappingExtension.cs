using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterPlanItemsMappingExtension
    {
        public static MasterPlanItems ToModel(this MasterPlanItemsViewModel model)
        {
            return new MasterPlanItems
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Desc = model.Desc,
                PlanId = model.PlanId,
            };

        }
        public static MasterPlanItemsViewModel ToViewModel(this MasterPlanItems model)
        {
            return new MasterPlanItemsViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Desc = model.Desc,
                PlanId = model.PlanId,
            };

        }
        public static List<MasterPlanItemsViewModel> ToViewModelList(this List<MasterPlanItems> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterPlanItems> ToViewModelList(this List<MasterPlanItemsViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
