using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Hospital
    {
        public Hospital()
        {
            this.Doctors = new HashSet<Doctor>();
            this.Hospitalizations = new HashSet<Hospitalization>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string AddressId { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }

        public virtual ICollection<Hospitalization> Hospitalizations { get; set; }


    }
}