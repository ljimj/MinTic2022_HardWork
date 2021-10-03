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
    public class EditarCrearEstudModel : PageModel
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        [BindProperty]
        
        public Estudiante estudiante{get;set;}
        
        public IActionResult OnGet(int? estudId)
        {
            if(estudId.HasValue)
            {
                estudiante = _repoEstudiante.GetEstudiante(estudId.Value);
            }else
            {
                estudiante = new Estudiante();
            }
            
            if(estudiante == null)
            {
                return RedirectToPage("/Index");
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
                if(estudiante.id>0)
                {
                    estudiante = _repoEstudiante.UpdateEstudiante(estudiante);
                }else{
                    _repoEstudiante.AddEstudiante(estudiante);
                }     
                return RedirectToPage("/Index");
            }
        }
    }
}
