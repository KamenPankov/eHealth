using System;
using System.Collections.Generic;
using System.Text;
using Services.ServiceModels;

namespace Services.PersonDiseasesInfoService
{
    public interface IPersonDiseasesService
    {
        void AddPersonDiseaseInfo(string doctorId, string personId, PersonDiseaseInfoInputModel personDiseaseInfoInputModel);
    }
}
