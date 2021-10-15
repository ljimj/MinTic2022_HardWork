using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Salones.App.Persistencia;
using Salones.App.Dominio;

namespace Salones.App.Frontend.Pages
{
    public class ListSedeModel : PageModel
    {
        private static IRepositorioSede _repoSede = new RepositorioSede(new Persistencia.AppContext());
        
        public IEnumerable<Sede> sedes{get;set;}
        
        public void OnGet()
        {
            sedes = _repoSede.GetAllSedes();
        }
    }
}
