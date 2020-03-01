using Data;
using Data.Models;
using Services.AddressesService;
using Services.EmailsService;
using Services.PhonesService;
using Services.ServiceModels;
using Services.VaccinesService;
using System;
using System.Linq;

namespace Services.DoctorsService
{
    public class DoctorsService : IDoctorsService
    {
        private readonly HealthDbContext db;

        private readonly IAddressesService addressesService;
        private readonly IPhonesService phonesService;
        private readonly IEmailsService emailsService;
        

        public DoctorsService(HealthDbContext db,
                              IAddressesService addressesService,
                              IPhonesService phonesService,
                              IEmailsService emailsService)
        {
            this.db = db;
            this.phonesService = phonesService;
            this.addressesService = addressesService;
            this.emailsService = emailsService;
            
        }

        public void Add(DoctorInputModel doctorInputModel)
        {
            Doctor doctor = new Doctor()
            {
                FirstName = doctorInputModel.FirstName,
                MiddleName = doctorInputModel.MiddleName,
                LastName = doctorInputModel.LastName,
                Specialty = doctorInputModel.Specialty,
                HospitalId = doctorInputModel.HospitalId
            };

            if (doctorInputModel.Address != null)
            {
                string addressId = this.addressesService.Add(doctorInputModel.Address);
                doctor.Addresses.Add(this.addressesService.GetAddress(addressId));
            }

            if (doctorInputModel.Phone != null)
            {
                string phoneId = this.phonesService.Add(doctorInputModel.Phone);
                doctor.Phones.Add(this.phonesService.GetPhone(phoneId));
            }

            if (doctorInputModel.Email != null)
            {
                string emailId = this.emailsService.Add(doctorInputModel.Email);
                doctor.Emails.Add(this.emailsService.GetEmail(emailId));
            }

            this.db.Doctors.Add(doctor);
            this.db.SaveChanges();
        }

        public void AddAddress(string doctorId, AddressInputModel addressInputModel)
        {
            Doctor doctor = this.GetDoctor(doctorId);

            string addressId = this.addressesService.Add(addressInputModel);

            doctor.Addresses.Add(this.addressesService.GetAddress(addressId));

            this.db.SaveChanges();
        }


        public void AddPhone(string doctorId, PhoneInputModel phoneInputModel)
        {
            Doctor doctor = this.GetDoctor(doctorId);

            string phoneId = this.phonesService.Add(phoneInputModel);

            doctor.Phones.Add(this.phonesService.GetPhone(phoneId));

            this.db.SaveChanges();
        }

        public void AddEmail(string doctorId, EmailAddressInputModel emailAddressInputModel)
        {
            Doctor doctor = this.GetDoctor(doctorId);

            string emailId = this.emailsService.Add(emailAddressInputModel);

            doctor.Emails.Add(this.emailsService.GetEmail(emailId));

            this.db.SaveChanges();
        }

        public Doctor GetDoctor(string doctorId)
        {
            return this.db.Doctors.FirstOrDefault(d => d.Id == doctorId);
        }

        

        
    }
}
