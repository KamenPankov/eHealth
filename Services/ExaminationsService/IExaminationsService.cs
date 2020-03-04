using Data.Models;
using Services.ServiceModels;
using System.Collections.Generic;
using System.Text;

namespace Services.ExaminationsService
{
    public interface IExaminationsService
    {
        string Add(ExaminationInputModel inputModel);

        void AddPrescription(string examinationId, string prescriptionId);

        void AddReferral(string examinationId, string referralId);

        Examination GetExamination(string examinationId);
    }
}
