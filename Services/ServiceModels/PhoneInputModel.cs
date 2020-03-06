using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Services.ServiceModels
{
    public class PhoneInputModel
    {
        [RegularExpression(@"\+\d{3}\d+", ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }
    }
}
