using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Prescription
    {
        public Prescription()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Medicines = new HashSet<Medicine>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string ExaminationId { get; set; }

        public virtual Examination Examination { get; set; }

        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}