using Data;
using Data.Models;
using Services.ServiceModels;

namespace Services.ReferralsService
{
    public class ReferralsService : IReferralsService
    {
        private readonly HealthDbContext db;

        public ReferralsService(HealthDbContext db)
        {
            this.db = db;
        }

        public string Add(ReferralInputModel inputModel)
        {
            Referral referral = new Referral()
            {
                Specialty = inputModel.Specialty,
                ExaminationId = inputModel.ExaminationId,
                Description = inputModel.Description
            };

            this.db.Referrals.Add(referral);
            this.db.SaveChanges();

            return referral.Id;
        }
    }
}
