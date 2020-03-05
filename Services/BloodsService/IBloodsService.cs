using Data;
using Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Services.BloodsService
{
    public interface IBloodsService
    {
        int GetBloodId(BloodType bloodType, RhD resusFactor);

        int GetBloodId(int bloodType, int resusFactor);

        IEnumerable<SelectListItem> AllBloodTypes();

        IEnumerable<SelectListItem> AllRhDs();
    }

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
                    Value = item as string
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
                    Value = item as string
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
            return this.db.Bloods
                .Where(b => (int)b.BloodType == bloodType && (int)b.RhD == resusFactor)
                .Select(b => b.Id)
                .FirstOrDefault();
        }
    }
}
