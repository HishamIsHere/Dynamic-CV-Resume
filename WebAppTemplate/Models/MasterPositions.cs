namespace WebAppTemplate.Models
{
    //    Table About: Id/ Image / Name / CV / Desc / DOB / Country / Address / Email / Phone nubmer

    //    Table social Media: Id / Icon / Link

    //    Table Positions: Id / Name / IsPrimary(for Position)

    //    Table Titles : Id / Title / Keyword
    public class MasterPositions : BaseEntity
    {
        public string Name { get; set; }
        public bool IsPrimary { get; set; }
    }
}
