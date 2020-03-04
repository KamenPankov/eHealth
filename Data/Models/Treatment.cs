using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Treatment
    {
        public Treatment()
        {
            this.Id = Guid.NewGuid().ToString();            
        }

        [Key]
        public string Id { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string DoctorId { get; set; }

        public Doctor Doctor { get; set; }

        
        public string HospitalizationId { get; set; }

        public Hospitalization Hospitalization { get; set; }

        public string ExaminationId { get; set; }

        public Examination Examination { get; set; }
    }
}