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
    public class EditarCrearProfeModel : PageModel
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        [BindProperty]
        
        public Profesor profesor{get;set;}
        
        public IActionResult OnGet(int? profeId)
        {
            if(profeId.HasValue)
            {
                profesor = _repoProfesor.GetProfesor(profeId.Value);
            }else
            {
                profesor = new Profesor();
            }
            
            if(profesor == null)
            {
                return RedirectToPage("/Personas/ListProfe");
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
                if(profesor.id>0)
                {
                    profesor = _repoProfesor.UpdateProfesor(profesor);
                    Console.WriteLine("Se actualizo un Profesor en la base de datos");

                }else{
                    _repoProfesor.AddProfesor(profesor);
                }     
                return RedirectToPage("/Personas/ListProfe");
            }
        }
    }
}
