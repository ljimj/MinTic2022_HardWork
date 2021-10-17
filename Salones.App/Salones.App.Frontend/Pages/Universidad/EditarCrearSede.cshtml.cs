using Microsoft.VisualBasic.CompilerServices;
using System.Dynamic;
using System.Net;
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
    public class EditarCrearSedeModel : PageModel
    {
        private static IRepositorioSede _repoSede = new RepositorioSede(new Persistencia.AppContext());
        private static IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        [BindProperty]
        public Sede sede{get;set;}
        //public IEnumerable<Salon> salones{get;set;}
        //public IEnumerable<Profesor> profesores{get;set;}
        //public IEnumerable<Estudiante> estudiantes{get;set;}
        //public IEnumerable<Directivo> directivos{get;set;}
        //public IEnumerable<PersonalAseo> personasAseo{get;set;}


        public IActionResult OnGet(int? sedeId)
        {
            //Personas que pueden ser autorizadas a entrar a la sede
            //var personas = new List <Persona>();
            //personas.Add((Persona)_repoDirectivo.GetAllDirectivos()); //Conversion implicita a Persona
            //personas.Add((Persona)_repoEstudiante.GetAllEstudiantes());
            //personas.Add((Persona)_repoProfesor.GetAllProfesores());
            //personas.Add((Persona)_repoPersonalAseo.GetAllPersonasAseo());
            
            //Los salones disponibles que se pueden agregar a la sede
            //salones = _repoSalon.GetAllSalones();

            if(sedeId.HasValue)
            {
                sede = _repoSede.GetSede(sedeId.Value);
                
            }else
            {
                sede = new Sede();   //Nueva sede
            }
            
            if(sede == null)
            {
                return RedirectToPage("/Universidad/ListSede");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            Console.WriteLine();
            if(!ModelState.IsValid)
            {
                Console.WriteLine("ups Error");
                return Page();
                                
            }else{
                if(sede.id!=0)
                {
                    sede = _repoSede.UpdateSede(sede);
                    Console.WriteLine("Se actualizo la sede en la base de datos");

                }else{
                    Console.WriteLine("--- else funcionando");
                    var listaSalones = new List<Salon>();
                    Console.WriteLine("--- Lista salones");
                    for (int i = 0; i < sede.cantidadSalones; i++)
                    {
                        var salon = new Salon{nombreSalon=Convert.ToString(i+1),capacidad=15,disponibilidad=true};
                        _repoSalon.AddSalon(salon);
                        listaSalones.Add(salon);
                        Console.WriteLine("Nombre Salon: " + salon.nombreSalon);
                    }
                    sede.salones = listaSalones;
                    _repoSede.AddSede(sede);
                }     
                return RedirectToPage("/Universidad/ListSede");
            }
        }
    }
}
