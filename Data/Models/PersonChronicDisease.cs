using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class PersonChronicDisease
    {
        
        public string PersonId { get; set; }

        public Person Person { get; set; }

        public int ChronicDiseaseId { get; set; }

        public ChronicDisease ChronicDisease { get; set; }

        

        public DateTime DiagnosedOn { get; set; }

        [Required]
        public string DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

    }
}
