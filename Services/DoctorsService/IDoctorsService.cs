using Data.Models;
using Services.ContactsService;
using Services.ServiceModels;
using System.Collections.Generic;
using System.Text;

namespace Services.DoctorsService
{
    public interface IDoctorsService : IContactsService
    {
        void Add(DoctorInputModel doctorInputModel);

        Doctor GetDoctor(string doctorId);
    }
}
