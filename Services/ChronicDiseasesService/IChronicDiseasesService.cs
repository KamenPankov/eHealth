using Data.Models;
using System.Collections.Generic;
using System.Text;

namespace Services.ChronicDiseasesService
{
    public interface IChronicDiseasesService
    {
        int Add(string name);

        int GetDiseaseId(string name);

        ChronicDisease GetDisease(int diseaseId);
    }
}
