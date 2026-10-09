using System.ComponentModel.DataAnnotations;

namespace WebAppTemplate.ViewModels
{
    public class MasterSkillsFullViewModel
    {
        public int Id { get; set; }
        public int DeleteId { get; set; }
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = "Percentage must be between 0 and 100.")]
        public int Percentage { get; set; }
        public bool IsSoftSkill { get; set; }
        public bool IsKnowledge { get; set; }
        public bool IsActive { get; set; }
        public List<MasterSkillsViewModel> List { get; set; }
    }
}
