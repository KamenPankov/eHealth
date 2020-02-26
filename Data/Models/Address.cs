using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Address
    {
        public Address()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required, MaxLength(30)]
        public string Town { get; set; }

        [Required, MaxLength(50)]
        public string Street { get; set; }

        [MaxLength(100)]
        public string AdditionalDescription { get; set; }

        public string PersonId { get; set; }

        public Person Person { get; set; }

        public string DoctorId { get; set; }

        public Doctor Doctor { get; set; }

        public string RelativeId { get; set; }

        public Relative Relative { get; set; }

        //public int? HospitalId { get; set; }

        //public Hospital Hospital { get; set; }
    }
}