using System.Collections.Generic;
using Salones.App.Dominio;

namespace Salones.App.Persistencia
{
    public interface IRepositorioProfesor
    {
         //CRUD
        //GetAllProfesores
        IEnumerable<Profesor> GetAllProfesores();
        //AddProfesores
        Profesor AddProfesor(Profesor profesor);
        //updateProfesor
        Profesor UpdateProfesor(Profesor profesor);
        //DeleteProfesor
        void DeleteProfesor(int idProfesor);
        //GetProfesor
        Profesor GetProfesor(int idProfesor);
        //GetProfesorCovid
        Profesor GetProfesorCovid(int idProfesor);

    }

}    