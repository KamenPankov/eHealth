using Data.Models;

namespace Services.AllergiesServise
{
    public interface IAllergiesService
    {
        int Add(string name);

        int GetAllergyId(string name);

        Allergy GetAllergy(int allergyId);
    }
}
