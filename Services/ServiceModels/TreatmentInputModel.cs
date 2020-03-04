using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ServiceModels
{
    public class TreatmentInputModel
    {
        public string Description { get; set; }

        public string Date { get; set; }

        
        public string DoctorId { get; set; }       

        
        public string HospitalizationId { get; set; }
    }
}
