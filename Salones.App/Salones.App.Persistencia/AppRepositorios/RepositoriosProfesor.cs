
using Salones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Salones.App.Dominio
{
    public class RepositorioProfesor : IRepositorioProfesor
    {
        private readonly AppContext _appContext;
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

        Profesor IRepositorioProfesor.updateProfesor(Profesor profesor)
        {
            var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id == profesor.id);

            if(profesor!= null)
            {
                profesorEncontrado.nombre = profesor.nombre;
                profesorEncontrado.apellido =profesor.apellido;
                profesorEncontrado.TipoIdentificacion = profesor.tipoIdentificacion;
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


        Profesor IRepositorioProfesor.getProfesor(int idProfesor)
        {
            var profesorEncontrado=_appContext.Profesores.FirstOrDefault(p => p.id == idProfesor);
            return profesorEncontrado;
        }

        IEnumerable<Profesor> IRepositorioProfesor.GetAllProfesores()
        {
            return _appContext.Profesores;
        }




    }
}
