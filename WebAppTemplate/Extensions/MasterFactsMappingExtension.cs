using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterFactsMappingExtension
    {
        public static MasterFacts ToModel(this MasterFactsViewModel model)
        {
            return new MasterFacts
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Icon = model.Icon,
                Title = model.Title,
                Number = model.Number,
            };

        }
        public static MasterFactsViewModel ToViewModel(this MasterFacts model)
        {
            return new MasterFactsViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Icon = model.Icon,
                Title = model.Title,
                Number = model.Number,
            };

        }
        public static List<MasterFactsViewModel> ToViewModelList(this List<MasterFacts> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterFacts> ToViewModelList(this List<MasterFactsViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
