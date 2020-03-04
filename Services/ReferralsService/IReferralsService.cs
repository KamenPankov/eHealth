using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ReferralsService
{
    public interface IReferralsService
    {
        string Add(ReferralInputModel inputModel);
    }
}
