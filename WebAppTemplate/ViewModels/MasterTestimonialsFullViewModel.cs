namespace WebAppTemplate.ViewModels
{
    public class MasterTestimonialsFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public IFormFile Imagefile { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public List<MasterTestimonialsViewModel> List { get; set; }
    }
}
