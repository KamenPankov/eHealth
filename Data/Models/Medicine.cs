using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Medicine
    {
        public Medicine()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Prescriptions = new HashSet<Prescription>();
        }

        [Key]
        public string Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public string DaylyDoze { get; set; }        

        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}