using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Salones.App.Persistencia;
using Salones.App.Dominio;

namespace Salones.App.Frontend.Pages
{
    public class EliminarAseoModel : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        [BindProperty]
        public PersonalAseo personaAseo{get;set;}

        public IActionResult OnGet(int aseoId)
        {
            personaAseo = _repoPersonalAseo.GetPersonalAseo(aseoId);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repoPersonalAseo.DeletePersonalAseo(personaAseo.id);
            return RedirectToPage("/Index");
        }
    }
}
