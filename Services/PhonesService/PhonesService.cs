using Data;
using Data.Models;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.PhonesService
{
    public class PhonesService : IPhonesService
    {
        private readonly HealthDbContext db;

        public PhonesService(HealthDbContext db)
        {
            this.db = db;
        }

        public string Add(PhoneInputModel phoneInputModel)
        {
            Phone phone = new Phone()
            {
                PhoneNumber = phoneInputModel.PhoneNumber
            };

            this.db.Phones.Add(phone);
            this.db.SaveChanges();

            return phone.Id;
        }

        public Phone GetPhone(string id)
        {
            return this.db.Phones.FirstOrDefault(p => p.Id == id);
        }
    }
}
