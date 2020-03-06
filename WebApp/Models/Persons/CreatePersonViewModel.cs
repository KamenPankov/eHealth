using Microsoft.AspNetCore.Mvc.Rendering;
using Services.ServiceModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApp.CommonConstants;
using WebApp.ValidationAttributes;

namespace WebApp.Models.Persons
{
    public class CreatePersonViewModel
    {
        [Required]
        [MinLength(3, ErrorMessage = Constants.NameMinLenth)]
        [MaxLength(30, ErrorMessage = Constants.NameMaxLenth)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MinLength(3, ErrorMessage = Constants.NameMinLenth)]
        [MaxLength(30, ErrorMessage = Constants.NameMaxLenth)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = Constants.NameMinLenth)]
        [MaxLength(50, ErrorMessage = Constants.LastNameMaxLenth)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [PersonalNumberValidation]
        public string PersonalNumber { get; set; }

        [Required]
        [Display(Name = "Health Insurance Status")]
        public bool HasHealthInsurance { get; set; }

        [Display(Name = "Blood Type")]
        public int BloodId { get; set; }

        public IEnumerable<SelectListItem> BloodTypes { get; set; }

        [Display(Name = "RhD")]
        public int RhDId { get; set; }

        public IEnumerable<SelectListItem> RhDs { get; set; }

        public string DoctorId { get; set; }

        
        public AddressInputModel Address { get; set; }

        public PhoneInputModel Phone { get; set; }

        public EmailAddressInputModel Email { get; set; }
    }
}
