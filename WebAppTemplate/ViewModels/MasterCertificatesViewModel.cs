using System.ComponentModel.DataAnnotations;

namespace WebAppTemplate.ViewModels
{
    public class MasterCertificatesViewModel
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        [Range(0, 9999)]
        public int MembershipId { get; set; }
        public DateTime Date { get; set; }
        public IFormFile Imagefile { get; set; }
        public bool IsActive { get; set; }
    }
}
