using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class ChronicDisease
    {
        public ChronicDisease()
        {
            this.Persons = new HashSet<PersonChronicDisease>();
        }

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<PersonChronicDisease> Persons { get; set; }
    }
}
