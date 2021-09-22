using Microsoft.EntityFrameworkCore;
using Salones.App.Dominio;

namespace Salones.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}

        public DbSet<Directivo> Directivos {get;set;}

        public DbSet<Estudiante> Estudiantes {get;set;}

        public DbSet<PersonalAseo> PersonasAseo {get;set;}

        public DbSet<Profesor> Profesores {get;set;} 

        public DbSet<Covid> DiagnosticosCovid {get;set;}

        public DbSet<Sede> Sedes {get;set;}

        public DbSet<Salon> Salones {get;set;}

        public DbSet<Ingreso> IngresosSalon {get;set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = SalonesDataHW");
                //Conexion en la máquina de Marco
                optionsBuilder.UseSqlServer("Data Source =localhost; Initial Catalog = SalonesDataHW;trusted_connection=true;");
            }
        }

    }
}

     
