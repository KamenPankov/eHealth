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

        void VaccinatePerson(string doctorId, string personId, VaccineInputModel vaccineInputModel);

        void AddAllergy(string doctorId, string personId, AllergyInputModel vaccineInputModel);

        void AddChronicDisease(string doctorId, string personId, ChronicDiseaseInputModel vaccineInputModel);

        Doctor GetDoctor(string doctorId);
    }
}
