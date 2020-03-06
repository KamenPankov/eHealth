using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Person : Contact
    {
        public Person() : base()
        {
            this.Relatives = new HashSet<PersonRelative>();                       
            this.Vaccines = new HashSet<PersonVaccine>();
            this.Allergies = new HashSet<PersonAllergy>();
            this.Examinations = new HashSet<Examination>();
            this.ChronicDiseases = new HashSet<PersonChronicDisease>();
            this.Hospitalizations = new HashSet<Hospitalization>();
        }

        [Required, RegularExpression(@"\d{10}")]
        public string PersonalNumber { get; set; }

        public bool HasHealthInsurance { get; set; }

        public int? BloodId { get; set; }

        public Blood Blood { get; set; }

        public string DoctorId { get; set; }
        
        public virtual Doctor DoctorGP { get; set; }

        public virtual ICollection<PersonRelative> Relatives { get; set; }

        public virtual ICollection<PersonVaccine> Vaccines { get; set; }

        public virtual ICollection<PersonAllergy> Allergies { get; set; }

        public virtual ICollection<Examination> Examinations { get; set; }

        public virtual ICollection<PersonChronicDisease> ChronicDiseases { get; set; }

        public virtual ICollection<Hospitalization> Hospitalizations { get; set; }
    }
}
