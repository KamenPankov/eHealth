using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Examination
    {
        public Examination()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Treatments = new HashSet<Treatment>();
        }

        [Key]
        public string Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Diagnosis { get; set; }

        public string PrescriptionId { get; set; }

        public virtual Prescription Prescription { get; set; }

        public string ReferralId { get; set; }

        public virtual Referral Referral { get; set; }

        public string PersonId { get; set; }

        public virtual Person Person { get; set; }

        public string DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

        public string HospitalizationId { get; set; }

        public Hospitalization Hospitalization { get; set; }

        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
