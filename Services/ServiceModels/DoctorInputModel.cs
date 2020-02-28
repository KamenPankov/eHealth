using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ServiceModels
{
    public class DoctorInputModel
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Specialty { get; set; }

        public int HospitalId { get; set; }

        public PhoneInputModel Phone { get; set; }

        public EmailAddressInputModel Email { get; set; }

        public AddressInputModel Address { get; set; }
    }
}
