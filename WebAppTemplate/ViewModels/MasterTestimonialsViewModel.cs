namespace WebAppTemplate.ViewModels
{
    public class MasterTestimonialsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public IFormFile Imagefile { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
