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
            this.Medicines = new HashSet<PrescriptionMedicine>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string ExaminationId { get; set; }

        public virtual Examination Examination { get; set; }

        public virtual ICollection<PrescriptionMedicine> Medicines { get; set; }
    }
}