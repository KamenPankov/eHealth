using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class PersonAllergy
    {
        public PersonAllergy()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Key]
        public string PersonId { get; set; }

        public Person Person { get; set; }

        public int AllergyId { get; set; }

        public Allergy Allergy { get; set; }

        

        public DateTime DiagnosedOn { get; set; }

        [Required]
        public string DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

    }
}