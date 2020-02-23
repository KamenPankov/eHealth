using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class PrescriptionMedicineConfiguration : IEntityTypeConfiguration<PrescriptionMedicine>
    {
        public void Configure(EntityTypeBuilder<PrescriptionMedicine> prescriptionMedicine)
        {
            prescriptionMedicine.HasKey(pm => new { pm.PrescriptionId, pm.MedicineId });
        }
    }
}
