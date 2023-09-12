using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SolutionPortalBeta.Shared
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? UserName { get; set; }

        //[ForeignKey("CompanyModel")]
        public int CompanyId { get; set; }
        //public CompanyModel? Company { get; set; }
    }
}
