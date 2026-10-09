using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterCertificatesMappingExtension
    {
        public static MasterCertificates ToModel(this MasterCertificatesViewModel model)
        {
            return new MasterCertificates
            {
                IsActive = model.IsActive,
                Id = model.Id,
                ImageURL = model.ImageURL,
                Title = model.Title,
                MembershipId = model.MembershipId,
                Date = model.Date,
            };

        }
        public static MasterCertificatesViewModel ToViewModel(this MasterCertificates model)
        {
            return new MasterCertificatesViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                ImageURL = model.ImageURL,
                Title = model.Title,
                MembershipId = model.MembershipId,
                Date = model.Date,
            };

        }
        public static List<MasterCertificatesViewModel> ToViewModelList(this List<MasterCertificates> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterCertificates> ToViewModelList(this List<MasterCertificatesViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
