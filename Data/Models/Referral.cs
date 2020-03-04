using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Referral
    {
        public Referral()
        {
            this.Id = Guid.NewGuid().ToString();
            
        }

        [Key]
        public string Id { get; set; }

        public string Specialty { get; set; }

        public string ExaminationId { get; set; }

        public virtual Examination Examination { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}