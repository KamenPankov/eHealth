using Microsoft.AspNetCore.Mvc;
using Services.BloodsService;
using Services.PersonsService;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.Persons;

namespace WebApp.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IPersonsService personsService;
        private readonly IBloodsService bloodsService;

        public PersonsController(IPersonsService personsService, IBloodsService bloodsService)
        {
            this.personsService = personsService;
            this.bloodsService = bloodsService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreatePersonViewModel viewModel = new CreatePersonViewModel()
            {
                BloodTypes = this.bloodsService.AllBloodTypes(),
                RhDs = this.bloodsService.AllRhDs()
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreatePersonViewModel viewModel)
        {
            PersonInputModel inputModel = new PersonInputModel()
            {
                FirstName = viewModel.FirstName,
                MiddleName = viewModel.MiddleName,
                LastName = viewModel.LastName,
                PersonalNumber = viewModel.PersonalNumber,
                Address = new AddressInputModel()
                {
                    Town = viewModel.Address.Town,
                    Street = viewModel.Address.Street,
                    AdditionalDescription = viewModel.Address.AdditionalDescription
                },
                Phone = new PhoneInputModel()
                {
                    PhoneNumber = viewModel.Phone.PhoneNumber
                },
                Email = new EmailAddressInputModel()
                {
                    Email = viewModel.Email.Email
                },
                BloodId = this.bloodsService.GetBloodId(viewModel.BloodId, viewModel.RhDId) == 0 ?
                          null : (int?)this.bloodsService.GetBloodId(viewModel.BloodId, viewModel.RhDId),
                HasHealthInsurance = viewModel.HasHealthInsurance,
                DoctorId = viewModel.DoctorId
            };

            if (!ModelState.IsValid)
            {
                viewModel.BloodTypes = this.bloodsService.AllBloodTypes();
                viewModel.RhDs = this.bloodsService.AllRhDs();

                return this.View(viewModel);
            }

            this.personsService.Add(inputModel);

            return this.Redirect("/");
        }
    }
}
