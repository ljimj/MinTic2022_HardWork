//interfas profesor

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
        Profesor updateProfesor(Profesor profesor);
        //DeleteProfesor
        void DeleteProfesor(int idProfesor);
        //getProfesor
        Profesor getProfesor(int idProfesor);
    }
}
