using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterClientsMappingExtension
    {
        public static MasterClients ToModel(this MasterClientsViewModel model)
        {
            return new MasterClients
            {
                IsActive = model.IsActive,
                Id = model.Id,
                ImageURL = model.ImageURL,
                Alt = model.Alt,

            };

        }
        public static MasterClientsViewModel ToViewModel(this MasterClients model)
        {
            return new MasterClientsViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                ImageURL = model.ImageURL,
                Alt = model.Alt,
            };

        }
        public static List<MasterClientsViewModel> ToViewModelList(this List<MasterClients> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterClients> ToViewModelList(this List<MasterClientsViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
