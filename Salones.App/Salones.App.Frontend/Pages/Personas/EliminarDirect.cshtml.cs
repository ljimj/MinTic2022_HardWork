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
    public class EliminarDirectModel : PageModel
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        [BindProperty]
        public Directivo directivo{get;set;}

        public IActionResult OnGet(int direcId)
        {
            directivo = _repoDirectivo.GetDirectivo(direcId);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repoDirectivo.DeleteDirectivo(directivo.id);
            return RedirectToPage("/Index");
        }
    }
}
