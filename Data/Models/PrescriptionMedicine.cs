namespace Data.Models
{
    public class PrescriptionMedicine
    {
        public string PrescriptionId { get; set; }

        public Prescription Prescription { get; set; }

        public string MedicineId { get; set; }

        public Medicine Medicine { get; set; }
    }
}
