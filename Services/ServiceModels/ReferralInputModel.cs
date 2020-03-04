using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ServiceModels
{
    public class ReferralInputModel
    {
        public string Specialty { get; set; }

        public string ExaminationId { get; set; }
        
        public string Description { get; set; }
    }
}
