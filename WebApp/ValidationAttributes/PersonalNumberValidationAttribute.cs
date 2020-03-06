using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebApp.CommonConstants;

namespace WebApp.ValidationAttributes
{
    public class PersonalNumberValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!Regex.IsMatch(value.ToString(), @"\d{10}"))
            {
                return new ValidationResult(Constants.PersonalNumberLength);
            }

            if (!IsValidEGN(value.ToString()))
            {
                return new ValidationResult(Constants.InvalidPersonalNumber);
            }

            return ValidationResult.Success;
        }

        private int GetYear(string egn)
        {
            int year = 0;
            int month = int.Parse(egn.Substring(2, 2));

            if (month > 40)
            {
                year = 2000 + int.Parse(egn.Substring(0, 2));
            }
            else if (month > 20)
            {
                year = 1800 + int.Parse(egn.Substring(0, 2));
            }
            else
            {
                year = 1900 + int.Parse(egn.Substring(0, 2));
            }

            return year;
        }

        private int GetMonth(string egn)
        {
            int month = int.Parse(egn.Substring(2, 2));

            if (month > 40)
            {
                month -= 40;
            }
            else if (month > 20)
            {
                month -= 20;
            }

            return month;
        }

        private int GetDay(string egn)
        {
            return int.Parse(egn.Substring(4, 2));
        }

        private DateTime GetDate(string egn)
        {
            int day = GetDay(egn);
            int month = GetMonth(egn);
            int year = GetYear(egn);

            return new DateTime(year, month, day);
        }

        private bool IsValidLastNumber(string egn)
        {
            int[] weight = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int sum = 0;

            for (int position = 0; position < egn.Length - 1; position++)
            {
                sum += int.Parse(egn.Substring(position, 1)) * weight[position];
            }

            int lastNumber = 0;

            if (sum % 11 < 10)
            {
                lastNumber = sum % 11;
            }

            return lastNumber == int.Parse(egn.Substring(9, 1));
        }

        private bool IsValidDate(string egn)
        {
            try
            {
                GetDate(egn);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool IsValidEGN(string egn)
        {
            return IsValidDate(egn) && IsValidLastNumber(egn);
        }
    }
}
