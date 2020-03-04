using Data.Models;
using Services.ServiceModels;
using System.Collections.Generic;
using System.Text;

namespace Services.TreatmentsService
{
    public interface ITreatmentsService
    {
        string Add(TreatmentInputModel inputModel);

        Treatment GetTreatment(string treatmentId);
    }
}
