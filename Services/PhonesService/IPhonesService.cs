using Data.Models;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.PhonesService
{
    public interface IPhonesService
    {
        string Add(PhoneInputModel phoneInputModel);

        Phone GetPhone(string id);
    }
}
