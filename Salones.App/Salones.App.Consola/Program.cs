using System.Dynamic;
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
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        private static IRepositorioCovid _repoCovid = new RepositorioCovid(new Persistencia.AppContext());
        private static IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
        private static IRepositorioSede _repoSede = new RepositorioSede(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddDirectivo();  //Por si se desea ejecutar
            //AddProfesor();
            //AddEstudiante();
            //AddSalon();
            //AddPersonalAseo();
            //AddSede();

            
            
            //Profesor profe1 = BuscarProfesorCovid(34);
            //Profesor profe2 = BuscarProfesorCovid(36);

            Salon salon1 = BuscarSalon(2);
            //Salon salon2 = BuscarSalon(3);

            //BuscarDirectivo(8); //Por si se desea ejecutar
            //BuscarProfesor(9); //Por si se desea ejecutar
            //BuscarEstudiante(10); //Por si se desea ejecutar
        
            PersonalAseo personalA1 = BuscarPersonalAseo(41); 

            
            AddPersonaSalonaSede(5, personalA1, salon1);
            //AddPersonaSalonaSede(5, profe2, salon2);

            //ActualizarDirectivo(); //Por si se desea ejecutar
            //ActualizarProfesor();
            //ActualizarEstudiante();
            //ActualizarPersonalAseo(1027);
            
            //EliminarDirectivo(5); //Por si se desea ejecutar
            //EliminarProfesor(6);
            //EliminarEstudiante(7);
            //EliminarPersonalAseo(1023);
            
            
            //BuscarDirectivos(); //Por si se desea ejecutar
            //BuscarProfesores();
            //BuscarEstudiantes();
            //BuscarPersonasAseo();
            //BuscarPersonalAseo(24);

             
        }
        //AddProfesor
        private static Profesor AddProfesor()
        {
            var profesor = new Profesor 
            {
               nombres = "Camilo Andres",
               apellidos = "Gonzales Suarez",
               tipoIdentificacion = TipoIdentificacion.CC,
               identificacion = "1022345908",
               edad = 37,
               estadoCovid = new Covid{sintomas=true, tipoSintomas=TipoSintomas.Fiebre, estadoCovid=true, fechaDiagnostico = new DateTime(2021,10,06,10,30,15), periodoAislamiento = 0},
               departamento = "Ciencias de Educacion",
               materia = "Ciencias sociales",
               facultad = Facultad.Ingenierias
            };

            Console.WriteLine(profesor.nombres+" "+profesor.apellidos+" \n-Estado Covid: "+ profesor.estadoCovid.estadoCovid);
            Profesor profesor_retornado = _repoProfesor.AddProfesor(profesor);
            if (profesor_retornado!=null)
                Console.WriteLine("Se registro un Profesor en la base de datos");
            return profesor_retornado;

        }
        //GetProfesor
        private static Profesor BuscarProfesor(int idProfesor)
        {
            var profesor = _repoProfesor.GetProfesor(idProfesor);
            Console.WriteLine(profesor.nombres+" "+profesor.apellidos+"\n-Materia: "+profesor.materia+"\n-Identificación: "+profesor.identificacion);
            return profesor;
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
                nombreSalon = "305",
                capacidad = 28,
                disponibilidad = true,
            };

            Console.WriteLine("-Salon: "+salon.nombreSalon+"\n-Capacidad: "+salon.capacidad+" \n-Disponibilidad: "+ salon.disponibilidad);
            Salon salon_retornado = _repoSalon.AddSalon(salon);
            if (salon_retornado!=null)
                Console.WriteLine("Se registro un Salon en la base de datos");
            return salon_retornado;

        }

        //GetSalon
        private static Salon BuscarSalon(int idSalon)
        {
            var salon = _repoSalon.GetSalon(idSalon);
            return salon;
        }


        /*

         //CRUD
        //--GetAllPersonasAseo
        IEnumerable<PersonalAseo> GetAllPersonasAseo();
        //--AddPersonalAseo
        PersonalAseo AddPersonalAseo(PersonalAseo personalAseo);
        //--updatePersonalAseo
        PersonalAseo UpdatePersonalAseo(PersonalAseo personalAseo);
        //DeletePersonalAseo
        void DeletePersonalAseo(int idPersonalAseo);
        //--GetPersonalAseo
        PersonalAseo GetPersonalAseo(int idPersonalAseo);


        */
        
        
        //AddPersonalAseo
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
           

        }

            //GetPersonalAseo
        private static PersonalAseo BuscarPersonalAseo(int idPersonalAseo)
        {
            var personalAseo = _repoPersonalAseo.GetPersonalAseo(idPersonalAseo);
            Console.WriteLine(personalAseo.nombres+" "+personalAseo.apellidos+"\n-turno: "+personalAseo.turno+"\n-Identificación: "+personalAseo.identificacion+"\n estado covid"+personalAseo.estadoCovid.sintomas );
            return personalAseo;
        }


        //GetAllPersonasAseo

        private static void BuscarPersonasAseo()
        {
            IEnumerable<PersonalAseo> personasAseo = _repoPersonalAseo.GetAllPersonasAseo();
            
            foreach (var personalAseo in personasAseo)
            {
                Console.WriteLine(personalAseo.id+"-"+personalAseo.nombres,"\n"+personalAseo.estadoCovid.sintomas );
               
            }
            
        }

        //updatePersonalAseo
        private static void ActualizarPersonalAseo()
        {
            var personalAseo = new PersonalAseo 
            {
               id = 24,
               nombres = "Mario",
               apellidos = "satoshi",
               tipoIdentificacion = TipoIdentificacion.CC,
               identificacion = "7777777",
               edad = 55,
               estadoCovid = new Covid{sintomas=false, tipoSintomas=TipoSintomas.Ninguno, estadoCovid=true, fechaDiagnostico = new DateTime(2021,10,13,10,30,15), periodoAislamiento = 10},
               turno = "5",
            };
            PersonalAseo personalAseo_retornado =_repoPersonalAseo.UpdatePersonalAseo(personalAseo);                         
            if (personalAseo_retornado!=null)
                Console.WriteLine("Se actualizó un persona de Aseo en la base de datos");
        
        }

        //DeleteDirectivo
        private static void EliminarPersonalAseo(int idPersonalAseo)
        {
            _repoPersonalAseo.DeletePersonalAseo(idPersonalAseo);
        }


        


        
        //Adicionar Sede
        private static Sede AddSede()
        {
            var sede  = new Sede
            {
                cantidadSalones = 55,
                salones=new List<Salon>{
                    new Salon{nombreSalon="201",capacidad=30,disponibilidad=true},
                    new Salon{nombreSalon="202",capacidad=30,disponibilidad=true},
                    new Salon{nombreSalon="203",capacidad=30,disponibilidad=true}
                },
                personasAutorizadas=new List<Persona>{
                    new Persona{nombres="Jacobo",apellidos="Jaramillo", tipoIdentificacion=TipoIdentificacion.CC, identificacion="1010345678",edad=34,estadoCovid = new Covid {sintomas=false, tipoSintomas=TipoSintomas.Ninguno, estadoCovid=false, fechaDiagnostico = new DateTime(2021,10,13,10,30,15), periodoAislamiento = 0}},
                    new Persona{nombres="Tatiana",apellidos="Gómez", tipoIdentificacion=TipoIdentificacion.CC, identificacion="1010765432",edad=45, estadoCovid = new Covid {sintomas=false, tipoSintomas=TipoSintomas.Ninguno, estadoCovid=false, fechaDiagnostico = new DateTime(2021,10,13,10,30,15), periodoAislamiento = 0}},
                    new Persona{nombres="Rolando",apellidos="Suarez", tipoIdentificacion=TipoIdentificacion.CC, identificacion="78546321",edad=55, estadoCovid = new Covid {sintomas=false, tipoSintomas=TipoSintomas.Ninguno, estadoCovid=false, fechaDiagnostico = new DateTime(2021,10,13,10,30,15), periodoAislamiento = 0}}
                },               
            };
            Sede sede_retornado =_repoSede.AddSede(sede);
            return sede_retornado;
        }

        private static void AddPersonaSalonaSede(int idSede, Persona persona, Salon salon)
        {
            var sede = _repoSede.GetSede(idSede);
            if(sede!=null)
            {
                if(sede.personasAutorizadas!=null)
                {
                    sede.personasAutorizadas.Add(persona);
                }
                else
                {
                    sede.personasAutorizadas = new List<Persona> ();
                    sede.personasAutorizadas.Add(persona);
                }

                if(sede.salones!=null)
                {
                    sede.salones.Add(salon);
                }
                else
                {
                    sede.salones = new List<Salon> ();
                    sede.salones.Add(salon);
                }
                _repoSede.UpdateSede(sede);
            }
        }

    }
}
