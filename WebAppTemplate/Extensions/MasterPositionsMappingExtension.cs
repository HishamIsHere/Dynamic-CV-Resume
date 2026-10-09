using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterPositionsMappingExtension
    {
        public static MasterPositions ToModel(this MasterPositionsViewModel model)
        {
            return new MasterPositions
            {
                IsActive = model.IsActive,
                IsPrimary = model.IsPrimary,
                Name = model.Name,
                Id = model.Id,
            };

        }
        public static MasterPositionsViewModel ToViewModel(this MasterPositions model)
        {
            return new MasterPositionsViewModel
            {
                IsActive = model.IsActive,
                IsPrimary = model.IsPrimary,
                Name = model.Name,
                Id = model.Id,
            };

        }
        public static List<MasterPositionsViewModel> ToViewModelList(this List<MasterPositions> model)
        {
            return model.Select(x=>x.ToViewModel()).ToList();

        }
        public static List<MasterPositions> ToViewModelList(this List<MasterPositionsViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
