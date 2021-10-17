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
    public class DetallesSalonModel : PageModel
    {
        private static IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
        
        public Salon salon{get;set;}
        
        public IActionResult OnGet(int salonId)
        {
            salon = _repoSalon.GetSalon(salonId);
            if(salon == null)
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
