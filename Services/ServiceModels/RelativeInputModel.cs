using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ServiceModels
{
    public class RelativeInputModel
    {
        public string FirstName { get; set; }

        
        public string MiddleName { get; set; }

        
        public string LastName { get; set; }

        public string RelativeType { get; set; }

        public AddressInputModel  Address { get; set; }

        public PhoneInputModel Phone { get; set; }

        public EmailAddressInputModel Email { get; set; }
    }
}
