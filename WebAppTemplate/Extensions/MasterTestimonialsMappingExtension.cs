using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Extensions
{
    public static class MasterTestimonialsMappingExtension
    {
        public static MasterTestimonials ToModel(this MasterTestimonialsViewModel model)
        {
            return new MasterTestimonials
            {
                IsActive = model.IsActive,
                Id = model.Id,
                ImageURL = model.ImageURL,
                Name = model.Name,
                Desc = model.Desc,
                Title = model.Title,

            };

        }
        public static MasterTestimonialsViewModel ToViewModel(this MasterTestimonials model)
        {
            return new MasterTestimonialsViewModel
            {
                IsActive = model.IsActive,
                Id = model.Id,
                ImageURL = model.ImageURL,
                Name = model.Name,
                Desc = model.Desc,
                Title = model.Title,
            };

        }
        public static List<MasterTestimonialsViewModel> ToViewModelList(this List<MasterTestimonials> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterTestimonials> ToViewModelList(this List<MasterTestimonialsViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
