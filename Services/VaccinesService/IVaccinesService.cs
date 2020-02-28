﻿using Data.Models;
using System.Collections.Generic;
using System.Text;

namespace Services.VaccinesService
{
    public interface IVaccinesService
    {
        void Add(string name);

        int GetVaccineId(string name);

        Vaccine GetVaccine(int vaccineId);
    }
}
