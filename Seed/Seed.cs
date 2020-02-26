﻿using Data;
using Data.Models;
using System;
using System.Collections.Generic;

namespace SeedDb
{
    public class Seed
    {
        public void SeedMedicine(HealthDbContext db)
        {
            string[] ddd = 
            { 
                "300mg",
                "300mg",
                "150mg",
                "150mg",
                "20mg",
                "40mg",
                "20mg",
                "20mg",
                "20mg",
                "20mg",
                "20mg",
                "20mg",
                "40mg",
                "20mg",
                "20mg",
                "40mg",
                "40mg",
                "20mg",
                "20mg",
                "20mg",
                "40mg",
                "40mg",
                "20mg",
                "40mg",
                "40mg",
                "40mg",
                "40mg",
                "20mg",
                "40mg",
                "30mg",
                "30mg",
                "30mg",
                "30mg",
                "30mg",
                "30mg",
                "40mg",
                "20mg",
                "40mg",
                "20mg",
                "40mg",
                "20mg",
                "20mg",
                "40mg",
                "20mg",
                "20mg",
                "40mg",
                "20mg",
                "40mg",
                "20mg",
                "20mg",
                "20mg",
                "40mg",
                "40mg",
                "20mg",
                "40mg",
                "20mg",
                "20mg",
                "40mg",
                "10mg",
                "10mg",
                "10mg",
                "10mg",
                "250mg",
                "3g",
                "90mg",
                "110mg",
                "90mg",
                "3mg",
                "2mg/puffmg",
                "9mg",
                "500mg",
                "500mg",
                "250mg",
                "500mg",
                "250mg",
                "3000mg",
                "3000mg",
                "1000mg",
                "500mg",
                "250mg",
                "1000mg",
                "500mg",
                "4 g/60 ml",
                "300mg",
                "25 000 UU",
                "100 IU/ml - 3 mlIU",
                "100 IU/ml - 3 ml",
                "100 IU/ml - 3 ml",
                "100 IU/ml - 3 ml",
                "100 IU/ml - 3 mlIU",
                "100 IU/ml-3 ml",
                "300IU",
                "100 IU/ml - 3 ml",
                "100 IU/ml-3 ml",
                "300IU",
                "100 IU/ml - 3 ml",
                "300IU",
                "100 IU/ml - 3 mlIU",
                "100 IU/ml - 3 ml",
                "100 IU/ml - 3 ml",
                "300IU"
            };

            string[] name = 
            {
                "Histac",
                "Ranitidin Accord",
                "Ranitidin Accord",
                "RANITIDIN-TCHAIKAPHARMA",
                "FAMOTIDINE ALKALOID",
                "Famultran",
                "Famultran",
                "Bioprazol",
                "Bioprazol",
                "Helicid 20",
                "Helicid 20",
                "Omeprazole Accord",
                "Omeprazole Accord",
                "Omeprazol Genericon",
                "Ulcoprol",
                "Helix",
                "Noacid",
                "Noacid",
                "Nolpaza",
                "Nolpaza",
                "Nolpaza",
                "Panrazol",
                "Pantoprazole Aurobindo",
                "Pantoprazole Aurobindo",
                "PANTUL",
                "PRAZOLPAN",
                "PRAZOLPAN",
                "PRAZOLPAN",
                "Pulcet",
                "LANSOPROL",
                "LanzAcid",
                "Lanzul",
                "Rapilasole",
                "Rapilasole",
                "TevaLans",
                "Emanera",
                "Emanera",
                "Emanera",
                "Emanera",
                "Esmerol",
                "Esmerol",
                "HELIDES",
                "HELIDES",
                "HELIDES",
                "Meprezor",
                "Meprezor",
                "Meprezor",
                "Mesopral",
                "Mesopral",
                "NEXIUM 20",
                "NEXIUM 20",
                "NEXIUM 40",
                "NEXIUM 40",
                "Nexopral",
                "Nexopral",
                "Nexopral",
                "ORMUS",
                "ORMUS",
                "NEXIUM",
                "CERUCAL",
                "Degan",
                "Reglan",
                "URSOFALK",
                "HEPA-MERZ",
                "CARSIL",
                "Carsil Max",
                "Hepcarsil forte",
                "BUDENOFALK",
                "BUDENOFALK",
                "BUDENOFALK UNO",
                "SALAZOPYRIN EN",
                "SULFASALAZIN EN",
                "Mesalazin Unipharm",
                "SALOFALK",
                "SALOFALK",
                "Salofalk",
                "SALOFALK",
                "SALOFALK",
                "SALOFALK",
                "SALOFALK",
                "SALOFALK",
                "SALOFALK",
                "SALOFALK",
                "Kreon 25 000",
                "Panzytrat",
                "Actrapid Penfill",
                "Humulin M3",
                "Humulin N",
                "Humulin R",
                "Insulatard Penfill",
                "Insuman Basal",
                "Insuman Basal",
                "INSUMAN BASAL",
                "Insuman Comb 25",
                "Insuman Comb 25",
                "INSUMAN COMB 25",
                "Insuman Rapid",
                "INSUMAN RAPID",
                "INSUMAN RAPID",
                "Mixtard 30 Penfill",
                "Humalog"
            };

            List<Medicine> medicines = new List<Medicine>();

            for (int counter = 0; counter < name.Length; counter++)
            {
                Medicine medicine = new Medicine()
                {
                    Name = name[counter],
                    DaylyDoze = ddd[counter]
                };

                medicines.Add(medicine);
            }

            db.Medicines.AddRange(medicines);
            db.SaveChanges();
        }

        public void SeedHospital(HealthDbContext db)
        {
            string[] hospitalNames = 
            { 
                "УМБАЛ Царица Йоанна – ИСУЛ", 
                "УМБАЛСМ Н. И. Пирогов", 
                "УМБАЛ Александровска",
                "УМБАЛ Свети Иван Рилски",
                "СБАЛББ Света София"
            };

            string[] streets = 
            { 
                "ул. Бяло море 8",
                "бул. Генерал Едуард Тотлебен 21", 
                "бул. Свети Георги Софийски 1",
                "бул. Академик Иван Евстатиев Гешов 15",
                "бул. Академик Иван Евстатиев Гешов 19"
            };

            string[] towns =
            {
                "София",
                "София",
                "София",
                "София",
                "София"
            };

            List<Hospital> hospitals = new List<Hospital>();
            List<Address> addresses = new List<Address>();

            for (int counter = 0; counter < hospitalNames.Length; counter++)
            {
                Address address = new Address()
                {
                    Town = towns[counter],
                    Street = streets[counter]                    
                };

                addresses.Add(address);

                Hospital hospital = new Hospital()
                {
                    Name = hospitalNames[counter],
                    AddressId = address.Id
                };


                hospitals.Add(hospital);
            }

            db.Addresses.AddRange(addresses);
            db.Hospitals.AddRange(hospitals);
            db.SaveChanges();
        }
    }
}
