using Data;
using Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.BloodsService
{
    public interface IBloodsService
    {
        int GetBloodId(BloodType bloodType, RhD resusFactor);
    }

    public class BloodsService : IBloodsService
    {
        private readonly HealthDbContext bd;

        public BloodsService(HealthDbContext bd)
        {
            this.bd = bd;
        }

        public int GetBloodId(BloodType bloodType, RhD resusFactor)
        {
            return this.bd.Bloods
                .Where(b => b.BloodType == bloodType && b.RhD == resusFactor)
                .Select(b => b.Id)
                .FirstOrDefault();
        }
    }
}
