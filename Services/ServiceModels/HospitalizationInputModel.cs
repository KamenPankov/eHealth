using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ServiceModels
{
    public class HospitalizationInputModel
    {
        public string EnterDate { get; set; }

        public string DischargeDate { get; set; }

        public int HospitalId { get; set; }
       
        public string PersonId { get; set; }

        
    }
}
