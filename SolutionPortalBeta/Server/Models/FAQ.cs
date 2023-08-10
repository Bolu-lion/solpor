using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolutionPortalBeta.Server.Models
{
    [Table("FAQ", Schema = "dbo")]
    public class FAQ
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
