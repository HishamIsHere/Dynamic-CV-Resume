namespace WebAppTemplate.ViewModels
{
    public class MasterClientsViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string? Alt { get; set; }
        public IFormFile Imagefile { get; set; }
        public string ImageURL { get; set; }
    }
}
