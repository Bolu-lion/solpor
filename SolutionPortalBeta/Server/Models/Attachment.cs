namespace SolutionPortalBeta.Server.Models
{
    public class Attachment
    {
        public int AttachmentId { get; set; }
        public int ComplaintId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public UserComplaint Complaint { get; set; }
    }
}
