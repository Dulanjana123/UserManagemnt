using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;
using UserManagemnt.Models.MasterData;
using UserManagemnt.Repositories;

namespace UserManagemnt.Pages.Admin.Persons
{
    public class DetailModel : PageModel
    {
        private readonly IPersonRepository _personRepository;

        [BindProperty]
        public Person person { get; set; }

        public IFormFile profileImage { get; set; }

        public DetailModel(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public async Task OnGet(Guid id)
        {
            person = await _personRepository.GetAsync(id);
        }

    }
}
