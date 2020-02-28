using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ServiceModels
{
    public class VaccineInputModel
    {
        public string PersonId { get; set; }

        public int VaccineId { get; set; }  

        public string DiagnosedOn { get; set; }

        
        public string DoctorId { get; set; }
    }
}
