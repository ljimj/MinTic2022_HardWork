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
    public class EditarCrearSalonModel : PageModel
    {
        private static IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
        [BindProperty]
        
        public Salon salon{get;set;}
        
        public IActionResult OnGet(int? salonId)
        {
            if(salonId.HasValue)
            {
                salon = _repoSalon.GetSalon(salonId.Value);
            }else
            {
                salon = new Salon();
            }
            
            if(salon == null)
            {
                return RedirectToPage("/Universidad/ListSalon");
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
                Console.WriteLine("ups Error");
                return Page();
                                
            }else{
                if(salon.id>0)
                {
                    salon = _repoSalon.UpdateSalon(salon);
                    Console.WriteLine("Se actualizo un Salon en la base de datos");

                }else{
                    _repoSalon.AddSalon(salon);
                }     
                return RedirectToPage("/Universidad/ListSalon");
            }
        }
    }
}
