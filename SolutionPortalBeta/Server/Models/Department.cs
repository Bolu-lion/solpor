using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionPortalBeta.Server.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? UserName { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set;}
        public Company? Company { get; set;}
    }
}

