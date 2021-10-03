using System.IO;
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
    public class EditDirectModel : PageModel
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        [BindProperty]
        
        public Directivo directivo{get;set;}
        
        public IActionResult OnGet(int? direcId)
        {
            if(direcId.HasValue)
            {
                directivo = _repoDirectivo.GetDirectivo(direcId.Value);
            }else
            {
                directivo = new Directivo();
            }
            
            if(directivo == null)
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
                if(directivo.id>0)
                {
                    directivo = _repoDirectivo.UpdateDirectivo(directivo);
                }else{
                    _repoDirectivo.AddDirectivo(directivo);
                }     
                return RedirectToPage("/Index");
            }
        }
    }
}
