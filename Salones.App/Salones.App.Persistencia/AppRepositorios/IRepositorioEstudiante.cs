using System.Collections.Generic;
using Salones.App.Dominio;
/*IRepositorio Estudiante*/

/*
Atributos Persona:
public int id {get;set;}
public string nombres {get;set;}
public string apellidos {get;set;}
public TipoIdentificacion tipoIdentificacion {get;set;}
public string identificación {get;set;}
public int edad {get;set;}
public Covid estadoCovid {get;set;}

Atributos Estudiante
public string carrera{get;set;}
public string semestre{get;set;}
public Facultad facultad {get;set;}       
*/
namespace Salones.App.Persistencia
{
    public interface IRepositorioEstudiante
    {
        //GetAllEstudiante
        IEnumerable<Estudiante> GetAllEstudiantes();
        //AddEstudiante
        Estudiante AddEstudiante(Estudiante estudiante);
        //UpdateEstudiante
        Estudiante UpdateEstudiante(Estudiante estudiante);
        //DeleteEstudiante
        void DeleteEstudiante(int idEstudiante);
        //GetEstudiante
        Estudiante GetEstudiante(int idEstudiante);
    }
}