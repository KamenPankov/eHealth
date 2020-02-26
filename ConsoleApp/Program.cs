using Data;
using Microsoft.EntityFrameworkCore;
using SeedDb;
using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (HealthDbContext db = new HealthDbContext())
            {
                db.Database.Migrate();

                Seed seed = new Seed();

                //seed.SeedMedicine(db);
                //seed.SeedHospital(db);
                //seed.SeedBlood(db);
                //seed.SeedVaccine(db);
            }
        }
    }
}
