using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Hospitalization
    {
        public Hospitalization()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Treatments = new HashSet<Treatment>();
        }

        [Key]
        public string Id { get; set; }

        public DateTime EnterDate { get; set; }

        public DateTime? DischargeDate { get; set; }

        public int HospitalId { get; set; }

        public virtual Hospital Hospital { get; set; }

        public int PersonId { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
