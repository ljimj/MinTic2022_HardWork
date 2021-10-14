using System;
using Salones.App.Dominio;
using Salones.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace Salones.App.Consola
{
    class Program
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        private static IRepositorioCovid _repoCovid = new RepositorioCovid(new Persistencia.AppContext());
        private static IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());

        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddDirectivo();  //Por si se desea ejecutar
            //AddProfesor();
            //AddEstudiante();
            //AddSalon();
            //AddPersonalAseo();

            
            
            //BuscarProfesorCovid(34);
           // BuscarDirectivo(8); //Por si se desea ejecutar
            //BuscarProfesor(9); //Por si se desea ejecutar
            //BuscarEstudiante(10); //Por si se desea ejecutar
            //


            //ActualizarDirectivo(); //Por si se desea ejecutar
            //ActualizarProfesor();
            //ActualizarEstudiante();
            
            //EliminarDirectivo(5); //Por si se desea ejecutar
            //EliminarProfesor(6);
            //EliminarEstudiante(7);
            
            //BuscarDirectivos(); //Por si se desea ejecutar
            //BuscarProfesores();
            //BuscarEstudiantes();
             
        }
        //AddProfesor
        private static Profesor AddProfesor()
        {
            var profesor = new Profesor 
            {
               nombres = "Pedro Emilio",
               apellidos = "Santa Fernandez",
               tipoIdentificacion = TipoIdentificacion.CC,
               identificacion = "1010010334",
               edad = 37,
               estadoCovid = new Covid{sintomas=false, tipoSintomas=TipoSintomas.Ninguno, estadoCovid=false, fechaDiagnostico = new DateTime(2021,10,06,10,30,15), periodoAislamiento = 0},
               departamento = "Ingenieria de Sistemas",
               materia = "Programación básica",
               facultad = Facultad.Ingenierias
            };

            Console.WriteLine(profesor.nombres+" "+profesor.apellidos+" \n-Estado Covid: "+ profesor.estadoCovid.estadoCovid);
            Profesor profesor_retornado = _repoProfesor.AddProfesor(profesor);
            if (profesor_retornado!=null)
                Console.WriteLine("Se registro un Profesor en la base de datos");
            return profesor_retornado;

        }
        //GetProfesor
        private static void BuscarProfesor(int idProfesor)
        {
            var profesor = _repoProfesor.GetProfesor(idProfesor);
            Console.WriteLine(profesor.nombres+" "+profesor.apellidos+"\n-Materia: "+profesor.materia+"\n-Identificación: "+profesor.identificacion);
        }
        //DeleteProfesor
        private static void EliminarProfesor(int idProfesor)
        {
            _repoProfesor.DeleteProfesor(idProfesor);
        }
        //UpdateProfesor
        private static void ActualizarProfesor()
        {
            var profesor = new Profesor 
            {
               id = 9,
               nombres = "Andrea Carolina",
               apellidos = "Suarez Correa",
               tipoIdentificacion = TipoIdentificacion.CC,
               identificacion = "67456789",
               edad = 46,
               estadoCovid = null,
               departamento = "Ingenieria de Sistemas",
               materia = "Desarrollo de Software",
               facultad = Facultad.Ingenierias
            };
            Profesor profesor_retornado =_repoProfesor.UpdateProfesor(profesor);                         
            if (profesor_retornado!=null)
                Console.WriteLine("Se actualizó un profesor en la base de datos");
        
        }
        //GetAllProfesores
        private static void BuscarProfesores()
        {
            IEnumerable<Profesor> profesores = _repoProfesor.GetAllProfesores();
            
            foreach (var profesor in profesores)
            {
                Console.WriteLine(profesor.nombres);
            }
            
        }

        private static void AdicionarProfesorCovid()
        {
            var profesor = new Profesor 
            {
               nombres = "Pedro Emilio",
               apellidos = "Santa Fernandez",
               tipoIdentificacion = TipoIdentificacion.CC,
               identificacion = "1010010334",
               edad = 37,
               estadoCovid = new Covid{sintomas=false, tipoSintomas=TipoSintomas.Ninguno, estadoCovid=false, fechaDiagnostico = new DateTime(2021,10,06,10,30,15), periodoAislamiento = 0},
               departamento = "Ingenieria de Sistemas",
               materia = "Programación básica",
               facultad = Facultad.Ingenierias
            };

            Console.WriteLine(profesor.nombres+" "+profesor.apellidos+" \n-Estado Covid: "+ profesor.estadoCovid.estadoCovid);
            Profesor profesor_retornado = _repoProfesor.AddProfesor(profesor);
            if (profesor_retornado!=null)
                Console.WriteLine("Se registro un Profesor en la base de datos");
        }

        private static Profesor BuscarProfesorCovid(int idProfesor)
        {
            var profesor = _repoProfesor.GetProfesorCovid(idProfesor);
            Console.WriteLine(profesor.nombres+" "+profesor.apellidos+" \n-Estado Covid: "+ profesor.estadoCovid.estadoCovid);        
            return profesor; 
        }

        //AddEstudiante
        private static void AddEstudiante()
        {
            var estudiante = new Estudiante 
            {
                nombres = "Sofia",
                apellidos = "Gonzales Herrera",
                tipoIdentificacion = TipoIdentificacion.TarjetaIdentidad,
                identificacion = "1000789654",
                edad = 17,
                estadoCovid = null,
                carrera = "Licencitura en ciencias Sociales",
                semestre = "2",
                facultad = Facultad.Educacion
            };

            Console.WriteLine(estudiante.nombres+" "+estudiante.apellidos+" \n-Carrera: "+ estudiante.carrera);
            Estudiante estudiante_retornado = _repoEstudiante.AddEstudiante(estudiante);
            if (estudiante_retornado!=null)
                Console.WriteLine("Se registro un Estudiante en la base de datos");
        }
        //GetEstudiante
        private static void BuscarEstudiante(int idEstudiante)
        {
            var estudiante = _repoEstudiante.GetEstudiante(idEstudiante);
            Console.WriteLine(estudiante.nombres+" "+estudiante.apellidos+"\n-Carrera: "+estudiante.carrera+"\n-Identificación: "+estudiante.identificacion);
        }
        //DeleteEstudiante
        private static void EliminarEstudiante(int idEstudiante)
        {
            _repoEstudiante.DeleteEstudiante(idEstudiante);
        }
        //UpdateEstudiante
        private static void ActualizarEstudiante()
        {
            var estudiante = new Estudiante 
            {
               id = 10,
               nombres = "Sofia",
                apellidos = "Gonzales Herrera",
                tipoIdentificacion = TipoIdentificacion.TarjetaIdentidad,
                identificacion = "1000789654",
                edad = 17,
                estadoCovid = null,
                carrera = "Licencitura en Artes",
                semestre = "3",
                facultad = Facultad.Educacion
            };
            Estudiante estudiante_retornado =_repoEstudiante.UpdateEstudiante(estudiante);                         
            if (estudiante_retornado!=null)
                Console.WriteLine("Se actualizó un estudiante en la base de datos");
        
        }
        //GetAllEstudiantes
        private static void BuscarEstudiantes()
        {
            IEnumerable<Estudiante> estudiantes = _repoEstudiante.GetAllEstudiantes();
            
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine(estudiante.nombres);
            }
            
        }

        //AddDirectivo
        private static void AddDirectivo()
        {
            var directivo = new Directivo 
            {
                nombres = "Carlos Mario",
                apellidos = "Aponte Guerra",
                tipoIdentificacion = TipoIdentificacion.CC,
                identificacion = "79678543",
                edad = 47,
                estadoCovid = null,
                unidad = "304",
            };

            Console.WriteLine(directivo.nombres+" "+directivo.apellidos+" \n-Unidad: "+ directivo.unidad);
            Directivo directivo_retornado = _repoDirectivo.AddDirectivo(directivo);
            if (directivo_retornado!=null)
                Console.WriteLine("Se registro un Directivo en la base de datos");
        }
        //GetDirectivo
        private static void BuscarDirectivo(int idDirectivo)
        {
            var directivo = _repoDirectivo.GetDirectivo(idDirectivo);
            Console.WriteLine(directivo.nombres+" "+directivo.apellidos+"\n-Unidad: "+directivo.unidad+"\n-Identificación: "+directivo.identificacion);
        }
        //DeleteDirectivo
        private static void EliminarDirectivo(int idDirectivo)
        {
            _repoDirectivo.DeleteDirectivo(idDirectivo);
        }
        //UpdateDirectivo
        private static void ActualizarDirectivo()
        {
            var directivo = new Directivo 
            {
               id = 8,
               nombres = "Carlos Mario",
               apellidos = "Aponte Guerra",
               tipoIdentificacion = TipoIdentificacion.CC,
               identificacion = "86789543",
               edad = 53,
               estadoCovid = null,
               unidad = "507",
            };
            Directivo directivo_retornado =_repoDirectivo.UpdateDirectivo(directivo);                         
            if (directivo_retornado!=null)
                Console.WriteLine("Se actualizó un directivo en la base de datos");
        
        }
        //GetAllDirectivos
        private static void BuscarDirectivos()
        {
            IEnumerable<Directivo> directivos = _repoDirectivo.GetAllDirectivos();
            
            foreach (var directivo in directivos)
            {
                Console.WriteLine(directivo.nombres);
            }
            
        }

        //AddSalon
        private static Salon AddSalon()
        {
            var salon = new Salon 
            {
                nombreSalon = "201",
                capacidad = 30,
                disponibilidad = true,
            };

            Console.WriteLine("-Salon: "+salon.nombreSalon+"\n-Capacidad: "+salon.capacidad+" \n-Disponibilidad: "+ salon.disponibilidad);
            Salon salon_retornado = _repoSalon.AddSalon(salon);
            if (salon_retornado!=null)
                Console.WriteLine("Se registro un Salon en la base de datos");
            return salon_retornado;

        }


        /*

         //CRUD
        //GetAllPersonasAseo
        IEnumerable<PersonalAseo> GetAllPersonasAseo();
        //AddPersonalAseo
        PersonalAseo AddPersonalAseo(PersonalAseo personalAseo);
        //updatePersonalAseo
        PersonalAseo UpdatePersonalAseo(PersonalAseo personalAseo);
        //DeletePersonalAseo
        void DeletePersonalAseo(int idPersonalAseo);
        //GetPersonalAseo
        PersonalAseo GetPersonalAseo(int idPersonalAseo);


        */

        

        private static PersonalAseo AddPersonalAseo()
        {
            
            
            var personalAseo = new PersonalAseo 
            {
               nombres = "jacobo",
               apellidos = "perez cabal",
               tipoIdentificacion = TipoIdentificacion.CC,
               identificacion = "15555554",
               edad = 34,
               estadoCovid = new Covid{sintomas=false, tipoSintomas=TipoSintomas.Ninguno, estadoCovid=false, fechaDiagnostico = new DateTime(2021,10,13,10,30,15), periodoAislamiento = 0},
               turno = "1",
               
             
            };

            Console.WriteLine(personalAseo.nombres+" "+personalAseo.apellidos+" \n-Estado Covid: "+ personalAseo.estadoCovid.estadoCovid);
            PersonalAseo personalAseo_retornado = _repoPersonalAseo.AddPersonalAseo(personalAseo);
            if (personalAseo_retornado!=null)
                Console.WriteLine("Se registro un personal de aseo en la base de datos");
            return personalAseo_retornado;
           //prueba Leo

        }
        


 
    }
}
