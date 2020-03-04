namespace Services.ServiceModels
{
    public class ExaminationInputModel
    {
        public string Date { get; set; }
       
        public string Diagnosis { get; set; }

        public string PrescriptionId { get; set; }        

        public string ReferralId { get; set; }        

        public string PersonId { get; set; }        

        public string DoctorId { get; set; }
    }
}
