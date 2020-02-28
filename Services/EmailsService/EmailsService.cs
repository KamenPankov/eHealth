using Data;
using Data.Models;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.EmailsService
{
    public class EmailsService : IEmailsService
    {
        private readonly HealthDbContext db;

        public EmailsService(HealthDbContext db)
        {
            this.db = db;
        }

        public string Add(EmailAddressInputModel emailInputModel)
        {
            EmailAddress emailAddress = new EmailAddress()
            {
                Email = emailInputModel.Email
            };

            this.db.EmailAddresses.Add(emailAddress);
            this.db.SaveChanges();

            return emailAddress.Id;
        }

        public EmailAddress GetEmail(string id)
        {
           return this.db.EmailAddresses.FirstOrDefault(e => e.Id == id);
        }
    }
}
