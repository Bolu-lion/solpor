using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPortalBeta.Shared
{
    public class CompanyModel
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }

        public List<DepartmentModel> Departments { get; } = new();
    }
}
