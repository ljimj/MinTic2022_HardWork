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
    public class ListProfeModel : PageModel
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        
        public IEnumerable<Profesor> profesores{get;set;}
        
        public void OnGet()
        {
            profesores = _repoProfesor.GetAllProfesores();
        }
    }
}
