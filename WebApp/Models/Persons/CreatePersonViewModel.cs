using Microsoft.AspNetCore.Mvc.Rendering;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Persons
{
    public class CreatePersonViewModel
    {
        public string FirstName { get; set; }


        public string MiddleName { get; set; }


        public string LastName { get; set; }

        public string PersonalNumber { get; set; }

        public bool HasHealthInsurance { get; set; }

        public int BloodId { get; set; }

        public IEnumerable<SelectListItem> BloodTypes { get; set; }

        public int RhD { get; set; }

        public IEnumerable<SelectListItem> RhDs { get; set; }

        public string DoctorId { get; set; }

        public AddressInputModel Address { get; set; }

        public PhoneInputModel Phone { get; set; }

        public EmailAddressInputModel Email { get; set; }
    }
}
