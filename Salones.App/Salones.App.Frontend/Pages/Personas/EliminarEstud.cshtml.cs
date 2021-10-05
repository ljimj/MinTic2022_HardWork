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
    public class EliminarEstudModel : PageModel
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        [BindProperty]
        public Estudiante estudiante{get;set;}

        public IActionResult OnGet(int estudId)
        {
            estudiante = _repoEstudiante.GetEstudiante(estudId);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repoEstudiante.DeleteEstudiante(estudiante.id);
            return RedirectToPage("/Index");
        }
    }
}
