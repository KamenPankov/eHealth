using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Doctor : Contact
    {
        public Doctor() : base()
        {
            this.Persons = new HashSet<Person>();
            this.Examinations = new HashSet<Examination>();
            this.PersonAllergies = new HashSet<PersonAllergy>();
            this.PersonVaccines = new HashSet<PersonVaccine>();
            this.PersonChronicDiseases = new HashSet<PersonChronicDisease>();
            this.Treatments = new HashSet<Treatment>();
        }

        [Required]
        public string Specialty { get; set; }

        public int HospitalId { get; set; }

        public virtual Hospital Hospital { get; set; }

        public virtual ICollection<Person> Persons { get; set; }

        public virtual ICollection<Examination> Examinations { get; set; }

        public virtual ICollection<PersonAllergy> PersonAllergies { get; set; }

        public virtual ICollection<PersonVaccine> PersonVaccines { get; set; }

        public virtual ICollection<PersonChronicDisease> PersonChronicDiseases { get; set; }

        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}