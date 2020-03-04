using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.PrescriptionsService
{
    public interface IPrescriptionsService
    {
        string Add(string examinationId);

        void AddMedicine(string prescriptionId, MedicineInputModel inputModel);
    }
}
