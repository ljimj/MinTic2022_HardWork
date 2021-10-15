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
    public class DetallesSedeModel : PageModel
    {
        private static IRepositorioSede _repoSede = new RepositorioSede(new Persistencia.AppContext());

        public Sede sede {get;set;}
        
        public IActionResult OnGet(int sedeId)
        {
            sede = _repoSede.GetSede(sedeId);
            if(sede == null)
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
