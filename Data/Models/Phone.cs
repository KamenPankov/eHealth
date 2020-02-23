using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Phone
    {
        public Phone()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required, RegularExpression(@"\+\d{3}\d+")]
        public string PhoneNumber { get; set; }

        
        public string PersonId { get; set; }

        public Person Person { get; set; }

        public string DoctorId { get; set; }

        public Doctor Doctor { get; set; }

        public string RelativeId { get; set; }

        public Relative Relative { get; set; }
    }
}