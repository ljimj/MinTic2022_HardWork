using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace Salones.App.Frontend.Pages
{   
    [Authorize]
    public class ListasModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
