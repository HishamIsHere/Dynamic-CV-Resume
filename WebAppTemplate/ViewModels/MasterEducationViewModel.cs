using System.ComponentModel.DataAnnotations;

namespace WebAppTemplate.ViewModels
{
    public class MasterEducationViewModel
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public string University { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public bool IsActive { get; set; }
    }
}
