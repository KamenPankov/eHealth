using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.MedicinesService
{
    public interface IMedicinesService
    {
        string Add(MedicineInputModel inputModel);

        string GetMedicineId(string name);
    }
}
