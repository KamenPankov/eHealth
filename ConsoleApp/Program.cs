using Data;
using Microsoft.EntityFrameworkCore;
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
            }
        }
    }
}
