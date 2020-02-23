using System.Collections.Generic;

namespace Data.Models
{
    public class Relative : Contact
    {
        public Relative() : base()
        {
            this.Persons = new HashSet<PersonRelative>();
        }

        public string RelativeType { get; set; }

        public virtual ICollection<PersonRelative> Persons { get; set; }
    }
}