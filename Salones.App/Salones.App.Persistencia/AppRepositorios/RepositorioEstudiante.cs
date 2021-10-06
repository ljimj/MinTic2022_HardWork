using Salones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Salones.App.Persistencia

{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private static AppContext _appContext;

        public RepositorioEstudiante(AppContext appContext)
        {
            _appContext = appContext;
        }

        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            
            var estudianteAdicionado = _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            //return estudianteAdicionado;
            return estudianteAdicionado.Entity;
        }

        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == estudiante.id);
            if (estudianteEncontrado != null)
            {

                estudianteEncontrado.nombres = estudiante.nombres;
                estudianteEncontrado.apellidos = estudiante.apellidos;
                estudianteEncontrado.tipoIdentificacion = estudiante.tipoIdentificacion;
                estudianteEncontrado.identificacion = estudiante.identificacion;
                estudianteEncontrado.edad = estudiante.edad;
                estudianteEncontrado.estadoCovid = estudiante.estadoCovid;
                estudianteEncontrado.carrera = estudiante.carrera;
                estudianteEncontrado.semestre = estudiante.semestre;
                estudianteEncontrado.facultad = estudiante.facultad;

                _appContext.SaveChanges();
            }
            return estudianteEncontrado;
        }

        void IRepositorioEstudiante.DeleteEstudiante (int idEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
            if (estudianteEncontrado == null)
                return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();

        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int idEstudiante)
        {

            var EstudianteEncontrado= _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
            return EstudianteEncontrado;
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _appContext.Estudiantes;
        }
    }
}
/*
Directivo IRepositorioDirectivo.GetDirectivo(int idDirectivo)
        {

            var DirectivoEncontrado= _appContext.Directivos.FirstOrDefault(p => p.id == idDirectivo);
            return DirectivoEncontrado;
        }

        IEnumerable<Directivo> IRepositorioDirectivo.GetAllDirectivos()
        {
            return _appContext.Directivos;
        }
*/
