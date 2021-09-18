using Microsoft.EntityFrameworkCore;
using Salones.App.Dominio;

namespace Salones.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
    }
}

     
