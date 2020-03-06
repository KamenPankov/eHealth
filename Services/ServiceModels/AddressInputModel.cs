using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Services.ServiceModels
{
    public class AddressInputModel
    {
        
        [MaxLength(30, ErrorMessage = "Town name must be less than 30 characters.")]
        public string Town { get; set; }

        
        [MaxLength(50, ErrorMessage = "Street name must be less than 50 characters.")]
        public string Street { get; set; }

        [MaxLength(100, ErrorMessage = "Text must be less than 100 characters.")]
        public string AdditionalDescription { get; set; }
    }
}
