using Data.Models;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.EmailsService
{
    public interface IEmailsService
    {
        string Add(EmailAddressInputModel emailInputModel);

        EmailAddress GetEmail(string id);
    }
}
