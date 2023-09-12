using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionPortalBeta.Server.Models
{
	[Table("UserComplaint")]
	public class UserComplaint
	{
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public string Description { get; set; }
		[Required]
		public DateTime DateCreated { get; set; } = DateTime.Now.Date;
		[Required]
		public bool IsCompleted { get; set; } = false;
		public string? Response { get; set; }
        public List<Attachment>? Attachments { get; set; }
    }
}
