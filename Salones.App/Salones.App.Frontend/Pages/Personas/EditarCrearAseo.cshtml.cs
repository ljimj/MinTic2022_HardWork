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
    public class EditarCrearAseoModel : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        [BindProperty]
        
        public PersonalAseo personaAseo{get;set;}
        
        public IActionResult OnGet(int? aseoId)
        {
            if(aseoId.HasValue)
            {
                personaAseo = _repoPersonalAseo.GetPersonalAseo(aseoId.Value);
            }else
            {
                personaAseo = new PersonalAseo();
            }
            
            if(personaAseo == null)
            {
                return RedirectToPage("/Personas/ListAseo");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();                
            }else{
                if(personaAseo.id>0)
                {
                    personaAseo = _repoPersonalAseo.UpdatePersonalAseo(personaAseo);
                }else{
                    _repoPersonalAseo.AddPersonalAseo(personaAseo);
                }     
                return RedirectToPage("/Personas/ListAseo");
            }
        }
    }
}
