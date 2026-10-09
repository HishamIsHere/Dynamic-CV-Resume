using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterAboutMappingExtension
    {
        public static MasterAbout ToModel(this MasterAboutViewModel model)
        {
            return new MasterAbout
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                CVURL = model.CVURL,
                ImageURL = model.ImageURL,
                Desc = model.Desc,
                DateOfBirth = model.DateOfBirth,
                Country = model.Country,
                Address = model.Address,
                Email = model.Email,
                Phone = model.Phone,
            };

        }
        public static MasterAboutViewModel ToViewModel(this MasterAbout model)
        {
            return new MasterAboutViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                Name = model.Name,
                CVURL = model.CVURL,
                ImageURL = model.ImageURL,
                Desc = model.Desc,
                DateOfBirth = model.DateOfBirth,
                Country = model.Country,
                Address = model.Address,
                Email = model.Email,
                Phone = model.Phone,
                Age = DateTime.Now.Year - model.DateOfBirth.Year
            };

        }
        public static List<MasterAboutViewModel> ToViewModelList(this List<MasterAbout> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterAbout> ToViewModelList(this List<MasterAboutViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
