using Data;
using Data.Models;
using Data.Models.Enums;
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

        public void SeedBlood(HealthDbContext db)
        {
            string[] bloodTypes = { "A", "B", "AB", "O" };

            List<Blood> bloods = new List<Blood>();

            foreach (string bloodType in bloodTypes)
            {
                Blood bloodNegative = new Blood
                {
                    BloodType = (BloodType)Enum.Parse(typeof(BloodType), bloodType),
                    RhD = RhD.Negative
                };

                Blood bloodPositive = new Blood
                {
                    BloodType = (BloodType)Enum.Parse(typeof(BloodType), bloodType),
                    RhD = RhD.Positive
                };

                bloods.Add(bloodNegative);
                bloods.Add(bloodPositive);
            }

            db.Bloods.AddRange(bloods);
            db.SaveChanges();
        }

        public void SeedVaccine(HealthDbContext db)
        {
            string[] vaccineNames =
            {
                "Lopinavir/ Ritonavir",
                "Lopinavir/ Ritonavir",
                "Dolutegravir, Abacavir, Lamivudine",
                "Darunavir, Cobicistat",
                "Dolutegravir, Rilpivirine",
                "Emtricitabine, tenofovir alafenamide, darunavir and cobicistat",
                "Inosine pranobex",
                "Enfuvirtide",
                "Raltegravir",
                "Maraviroc",
                "Dolutegravir",
                "Anthrax antitoxin",
                "Diphteria antitoxin",
                "Tetanus antitoxin",
                "Viper venom antiserum",
                "Clostridium botulijum type A, Clostridium botulinum type B, Clostridium botulinum type E",
                "Immunoslobuline, Human Anti-Krimean Haemorrhagic fever",
                "Immunoglobuline, normal human for extravascular adm. Histamine dihydrochloride",
                "Immunoglobuline, normal human for extravascular adm.",
                "Immunoglobulins, normal human, for intravascular adm.",
                "Human normal immunoglobulin",
                "Haemophilus type b conjugated vaccine",
                "Haemophilus tipe b conjugate vaccine",
                "Diphtheria, tetanus and pertussis vaccine(adsorbed)",
                "Diphtheria, Tetanus and Pertussis(acellular, component) vaccine",
                "Diphtheria, Tetanus, Pertussis(acellular component) Vaccine(adsorbed, reduced antigen(s) content)",
                "Diphtheria, Tetanus, Pertussis(acellular component) Vaccine(adsorbed, reduced antigen(s) content)",
                "Pneumococcal polysaccharide vaccine",
                "Pneumococcal saccharide conjugated vaccine, absorbed",
                "Pneumococcal saccharide conjugated vaccine, absorbed",
                "Pneumococcal polysaccharide conjugate vaccine",
                "Tetanus Toxoid",
                "Diphtheria and tetanus vaccine(adsorbed, reduced antigen(s) content)",
                "Diphtheria and tetanus vaccine(ADSORBED)",
                "Mycobacterium bovis BCG",
                "Typhoid polysaccharide vaccine",
                "Influenza vaccine(split virion, inactivated)",
                "Influenza vaccine(split virion, inactivated)",
                "Influenza vaccine(split virion, inactivated)",
                "influenza, inactivated, split virus or surface antigen",
                "Hepatit B antigen, purified",
                "Hepatit B antigen, purified",
                "Hepatitis A vaccine(inactivated, adsorbed)",
                "Hepatitis A vaccine(inactivated, adsorbed)",
                "Hepatitis A(inactivated) and hepatitis B(rDNA)(HAB) vaccine(adsorbed)",
                "Measles, mumps and rubella vaccine, live",
                "Poliomyelitis vaccine, (live attenuated)",
                "Poliomyelitis vaccine(inactivated)",
                "Poliomyelitis vaccine, inactivated",
                "Rabies vaccine for human use prepared in cell cultures(inactivated)",
                "Rotavirus vaccine, live",
                "Rotavirus vaccine, live",
                "Rotavirus vaccine, live",
                "(Human papillomavirus Vaccine[Types 6, 11, 16, 18](Recombinant, adsorbed)) Адсорбирана ваксина срещу човешки папиломавирус[Тип 6, 11, 16, 18](рекомбинанта)",
                "Human Papillomavirus vaccine[Types 16, 18](Recombinant, adjuvanted, adsorbed)",
                "Crimean Haemorrhagic fever vaccine; inactivated",
                "Diphteria, Tetanus, pertussis(acellular) and poliomyelitis(inactivated) vaccine(adsorbed)",
                "Diphteria, tetanus, pertussis and poliomyelitis vaccine",
                "Diphteria, tetanus, pertussis(acellular, component) and Poliomyelitis(inactivated) vaccine(adsorbed)",
                "Diphteria, tetanus, pertussis(acellular, component), poliomyelitis(inactivated) and Haemophilis type b conjugate vaccine(adsorbed)",
                "Diphtheria, tetanus, pertussis(acellular, component), hepatitis B(rDNA), poliomyelitis(inactivated) and Haemophilus influenzae type b conjugate vaccine(adsorbed)",
                "Diphtheria, tetanus, pertussis(acellular, component), hepatitis B(rDNA), poliomyelitis(inactivated)",
                "Morphine",
                "Methadone",
                "Natural phospholipids",
                "Tuberculini purified Protein Derivative for human use",
                "Technetium exametazime",
                "Ioflupane",
                "Technetium medronic acid",
                "Technetium nanocolloid",
                "Technetium macrosalb",
                "Mo sodium molybdate; Tc Technetium  pertechnetate",
                "Sodium iodide[131 I]",
                "Technetium(99mTc) Sestamibi",
                "Technetium tetrofosmin",
                "Sodium chromate",
                "technetium(99mTc) hynic - octreotide",
                "Iobenguane",
                "Strontium chloride"
            };

            List<Vaccine> vaccines = new List<Vaccine>();

            for (int counter = 0; counter < vaccineNames.Length; counter++)
            {
                Vaccine vaccine = new Vaccine()
                {
                    Name = vaccineNames[counter]
                };

                vaccines.Add(vaccine);
            }

            db.Vaccines.AddRange(vaccines);
            db.SaveChanges();
        }

        public void SeedAllergy(HealthDbContext db)
        {
            string[] allergyNames =
            {
                "Balsam of Peru",
                "Egg",
                "Fish",
                "Fruit",
                "Garlic",
                "Hot peppers",
                "Oats",
                "Maize",
                "Milk[10]",
                "Peanut[12]",
                "Poultry Meat[13]",
                "Red Meat[15]",
                "Rice",
                "Sesame",
                "Shellfish",
                "Soy",
                "Sulfites",
                "Tartrazine",
                "Tree nut[25]",
                "Wheat[26]"
            };

            List<Allergy> allergies = new List<Allergy>();

            for (int counter = 0; counter < allergyNames.Length; counter++)
            {
                Allergy allergy = new Allergy()
                {
                    Name = allergyNames[counter]
                };

                allergies.Add(allergy);
            }

            db.Allergies.AddRange(allergies);
            db.SaveChanges();
        }

        public void SeedChronicDisease(HealthDbContext db)
        {
            string[] diseaseNames =
            {
                "Alzheimer diseaseanddementia",
                "Arthritis",
                "Asthma",
                "Cancer",
                "COPD",
                "Crohn disease",
                "Cystic fibrosis",
                "Diabetes",
                "Epilepsy",
                "Heart disease",
                "HIV/AIDS",
                "Mood disorders (bipolar,cyclothymic, anddepression)",
                "Multiple sclerosis",
                "Parkinson disease"
            };

            List<ChronicDisease> chronicDiseases = new List<ChronicDisease>();

            for (int counter = 0; counter < diseaseNames.Length; counter++)
            {
                ChronicDisease chronicDisease = new ChronicDisease()
                {
                    Name = diseaseNames[counter]
                };

                chronicDiseases.Add(chronicDisease);
            }

            db.ChronicDiseases.AddRange(chronicDiseases);
            db.SaveChanges();
        }

        public void SeedDataBase(HealthDbContext db)
        {
            this.SeedMedicine(db);
            this.SeedHospital(db);
            this.SeedBlood(db);
            this.SeedVaccine(db);
            this.SeedAllergy(db);
            this.SeedChronicDisease(db);

        }
    }
}
