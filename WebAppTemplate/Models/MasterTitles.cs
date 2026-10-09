namespace WebAppTemplate.Models
{
    //    Table About: Id/ Image / Name / CV / Desc / DOB / Country / Address / Email / Phone nubmer

    //    Table social Media: Id / Icon / Link

    //    Table Positions: Id / Name / IsPrimary(for Position)

    //    Table Titles : Id / Title / Keyword
    public class MasterTitles : BaseEntity
    {
        public string Title { get; set; }
        public string Keyword { get; set; }
    }
}
