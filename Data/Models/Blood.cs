using Data.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Blood
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public BloodType BloodType { get; set; }

        [Required]
        public RhD RhD { get; set; }

        public virtual ICollection<Person> Persons { get; set; } = new HashSet<Person>();
    }
}