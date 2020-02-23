using System;

namespace Data.Models
{
    public class PersonRelative
    {
        

        public string PersonId { get; set; }

        public Person Person { get; set; }

        public string RelativeId { get; set; }

        public Relative Relative { get; set; }
    }
}