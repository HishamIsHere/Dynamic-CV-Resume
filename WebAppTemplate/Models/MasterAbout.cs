using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Numerics;

namespace WebAppTemplate.Models
{
//    Table About: Id/ Image / Name / CV / Desc / DOB / Country / Address / Email / Phone nubmer

//    Table social Media: Id / Icon / Link

//    Table Positions: Id / Name / IsPrimary(for Position)

//    Table Titles : Id / Title / Keyword

    public class MasterAbout : BaseEntity
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string CVURL { get; set; }
        public string Desc { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
