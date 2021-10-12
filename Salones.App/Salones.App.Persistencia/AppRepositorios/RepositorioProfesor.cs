using System;
using Salones.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Salones.App.Persistencia
{



    public class RepositorioProfesor : IRepositorioProfesor
    {
        private static AppContext _appContext;

        public RepositorioProfesor(AppContext appContext)
        {
            _appContext = appContext;
        }

        Profesor IRepositorioProfesor.AddProfesor(Profesor profesor)
        {
            var profesorAdicinado = _appContext.Profesores.Add(profesor);
            _appContext.SaveChanges();
            return profesorAdicinado.Entity;
        }


        Profesor IRepositorioProfesor.UpdateProfesor(Profesor profesor)
        {
             var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id == profesor.id);

             if (profesorEncontrado != null)
            {
                profesorEncontrado.nombres = profesor.nombres;
                profesorEncontrado.apellidos=profesor.apellidos;
                profesorEncontrado.tipoIdentificacion = profesor.tipoIdentificacion;
                profesorEncontrado.identificacion = profesor.identificacion;
                profesorEncontrado.edad = profesor.edad;
                profesorEncontrado.estadoCovid =profesor.estadoCovid;
                profesorEncontrado.departamento=profesor.departamento;
                profesorEncontrado.materia=profesor.materia;
                profesorEncontrado.facultad = profesor.facultad;

                _appContext.SaveChanges();
            }

            return profesorEncontrado;
        }
        


        void IRepositorioProfesor.DeleteProfesor (int idProfesor)
        {
            var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id == idProfesor);
            

            if(profesorEncontrado== null)
               return;
            _appContext.Profesores.Remove(profesorEncontrado);
            _appContext.SaveChanges();

            
        }

        Profesor IRepositorioProfesor.GetProfesor(int idProfesor)
        {
            var ProfesorEncontrado=_appContext.Profesores.FirstOrDefault(p => p.id == idProfesor);
            return ProfesorEncontrado;
        }

        IEnumerable<Profesor> IRepositorioProfesor.GetAllProfesores()
        {
            return _appContext.Profesores;
        }

        Profesor IRepositorioProfesor.GetProfesorCovid(int idProfesor)
        {
            var profesorEncontrado= _appContext.Profesores.Include(p => p.estadoCovid).FirstOrDefault(p=>p.id==idProfesor);
            return profesorEncontrado;
        }


    }

}
