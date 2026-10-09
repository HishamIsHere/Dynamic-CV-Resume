namespace WebAppTemplate.Models
{
    public class MasterSkills : BaseEntity
    {
        public string Name { get; set; }
        public int Percentage { get; set; }
        public bool IsSoftSkill { get; set; }
        public bool IsKnowledge {  get; set; }
    }
}
