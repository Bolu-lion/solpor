using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPortalBeta.Shared
{
    public class AttachementModel
    {
            public int AttachmentId { get; set; }
            public int ComplaintId { get; set; }
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public string ContentType { get; set; }
            public long FileSize { get; set; }
        
    }
}
