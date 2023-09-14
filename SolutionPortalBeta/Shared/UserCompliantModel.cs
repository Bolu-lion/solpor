using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPortalBeta.Shared
{
    public class UserCompliantModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.Now.Date;

        [Required]
        [Display(Name ="Is Completed")]
        public bool IsCompleted { get; set; } 
        
        [Display(Name ="Response")]
        public string? Response { get; set; }

        [Display(Name = "Attachments")]
        public List<Attachment>? Attachments { get; set; }
    }
}
