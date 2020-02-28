using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ServiceModels
{
    public class AddressInputModel
    {
        public string Town { get; set; }
        
        public string Street { get; set; }
       
        public string AdditionalDescription { get; set; }
    }
}
