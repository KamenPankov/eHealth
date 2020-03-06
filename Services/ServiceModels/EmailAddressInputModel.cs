using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Services.ServiceModels
{
    public class EmailAddressInputModel
    {
        
        [MaxLength(50, ErrorMessage = "Email must be less than 50 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email.")]
        public string Email { get; set; }
    }
}
