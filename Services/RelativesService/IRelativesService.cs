using Data.Models;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.RelativesService
{
    public interface IRelativesService
    {
        string Add(RelativeInputModel relativeInputModel);

        Relative GetRelative(string id);
    }
}
