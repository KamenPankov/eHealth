using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Contact
    {
        public Contact()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Phones = new HashSet<Phone>();
            this.Emails = new HashSet<EmailAddress>();
            this.Addresses = new HashSet<Address>();
            
        }

        [Key]
        public string Id { get; set; }

        [Required, MaxLength(30)]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string MiddleName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }           

        public virtual ICollection<Phone> Phones { get; set; }

        public virtual ICollection<EmailAddress> Emails { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
