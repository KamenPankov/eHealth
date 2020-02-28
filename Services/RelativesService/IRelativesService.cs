using Data.Models;
using Services.ContactsService;
using Services.ServiceModels;

namespace Services.RelativesService
{
    public interface IRelativesService : IContactsService
    {
        string Add(RelativeInputModel relativeInputModel);

        Relative GetRelative(string id);
    }
}
