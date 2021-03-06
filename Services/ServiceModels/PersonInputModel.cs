﻿using Data.Models.Enums;
using System.Collections.Generic;

namespace Services.ServiceModels
{
    public class PersonInputModel
    {
        public string FirstName { get; set; }

        
        public string MiddleName { get; set; }

        
        public string LastName { get; set; }

        public string PersonalNumber { get; set; }

        public bool HasHealthInsurance { get; set; }

        public int? BloodId { get; set; }

        

        public string DoctorId { get; set; }

        public AddressInputModel Address { get; set; }

        public PhoneInputModel Phone { get; set; }

        public EmailAddressInputModel Email { get; set; }


       
    }
}