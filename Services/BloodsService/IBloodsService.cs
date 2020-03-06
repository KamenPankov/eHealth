using Data.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Services.BloodsService
{
    public interface IBloodsService
    {
        int GetBloodId(BloodType bloodType, RhD resusFactor);

        int GetBloodId(int bloodType, int resusFactor);

        IEnumerable<SelectListItem> AllBloodTypes();

        IEnumerable<SelectListItem> AllRhDs();
    }
}
