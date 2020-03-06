using Data;
using Data.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.BloodsService
{
    public class BloodsService : IBloodsService
    {
        private readonly HealthDbContext db;

        public BloodsService(HealthDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SelectListItem> AllBloodTypes()
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            foreach (var item in Enum.GetValues(typeof(BloodType)))
            {
                listItems.Add(new SelectListItem()
                {
                    Text = Enum.GetName(typeof(BloodType), item),
                    Value = Convert.ToInt32(item).ToString()
                });
            }

            return listItems;
        }

        public IEnumerable<SelectListItem> AllRhDs()
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            foreach (var item in Enum.GetValues(typeof(RhD)))
            {
                listItems.Add(new SelectListItem()
                {
                    Text = Enum.GetName(typeof(RhD), item),
                    Value = Convert.ToInt32(item).ToString()
                });
            }

            return listItems;
        }

        public int GetBloodId(BloodType bloodType, RhD resusFactor)
        {
            return this.db.Bloods
                .Where(b => b.BloodType == bloodType && b.RhD == resusFactor)
                .Select(b => b.Id)
                .FirstOrDefault();
        }

        public int GetBloodId(int bloodType, int resusFactor)
        {
            return this.db.Bloods.AsEnumerable()
                .Where(b => Convert.ToInt32(b.BloodType) == bloodType &&
                            Convert.ToInt32(b.BloodType) == resusFactor)
                .Select(b => b.Id)
                .FirstOrDefault();
        }
    }
}
