using Data.Models;
using Services.ServiceModels;
using System.Collections.Generic;
using System.Text;

namespace Services.HospitalizationsService
{
    public interface IHospitalizationsService
    {
        void Add(HospitalizationInputModel inputModel);

        Hospitalization GetHospitalization(string hospitalizationId);

        void AddTreatment(string hospitalizationId, string treatmentId);

        void AddExamination(string hospitalizationId, string examinationId);
    }
}
