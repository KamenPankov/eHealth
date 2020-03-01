using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class PersonVaccine
    {
        public PersonVaccine()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        public string PersonId { get; set; }

        public Person Person { get; set; }

        public int VaccineId { get; set; }

        public Vaccine Vaccine { get; set; }
        
        

        public DateTime DiagnosedOn { get; set; }

        [Required]
        public string DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

    }
}