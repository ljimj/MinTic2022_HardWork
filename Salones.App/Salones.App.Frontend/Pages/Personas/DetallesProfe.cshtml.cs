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
    public class DetallesProfeModel : PageModel
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        
        public Profesor profesor{get;set;}
        
        public IActionResult OnGet(int profeId)
        {
            profesor = _repoProfesor.GetProfesor(profeId);
            if(profesor == null)
            {
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
