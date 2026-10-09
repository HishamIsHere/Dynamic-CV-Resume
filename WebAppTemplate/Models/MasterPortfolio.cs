using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppTemplate.Models
{
    public class MasterPortfolio : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string ThumbnailImageURL { get; set; }
        public string ViewImageURL { get; set; }
        [ForeignKey("CategoryId")]
        public MasterCategory MasterCategory { get; set; }
    }
}
