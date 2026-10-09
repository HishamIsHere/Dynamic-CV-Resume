using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterPlansMappingExtension
    {
        public static MasterPlans ToModel(this MasterPlansViewModel model)
        {
            return new MasterPlans
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                PricePeriod = model.PricePeriod,
                IsSuggested = model.IsSuggested,

            };

        }
        public static MasterPlansViewModel ToViewModel(this MasterPlans model)
        {
            return new MasterPlansViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                PricePeriod = model.PricePeriod,
                IsSuggested = model.IsSuggested,
            };

        }
        public static List<MasterPlansViewModel> ToViewModelList(this List<MasterPlans> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterPlans> ToViewModelList(this List<MasterPlansViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
