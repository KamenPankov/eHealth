using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Allergy
    {
        public Allergy()
        {
            this.Persons = new HashSet<PersonAllergy>();
        }

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        public ICollection<PersonAllergy> Persons { get; set; }
    }
}