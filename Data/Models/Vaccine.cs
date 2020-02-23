using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Vaccine
    {
        public Vaccine()
        {
            this.Persons = new HashSet<PersonVaccine>();
        }

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }
        
        public ICollection<PersonVaccine> Persons { get; set; }
    }
}