using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class EmailAddress
    {
        public EmailAddress()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required, MaxLength(50), EmailAddress]
        public string Email { get; set; }


        public string PersonId { get; set; }

        public Person Person { get; set; }

        public string DoctorId { get; set; }

        public Doctor Doctor { get; set; }

        public string RelativeId { get; set; }

        public Relative Relative { get; set; }
    }
}