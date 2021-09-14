using System;

namespace Salones.App.Dominio
{
    // Clase para representar profesores
    // Hereda de la clase Persona
    public class Profesor:Persona
    {
        public string departamento{get;set;}
        public string materia{get;set;}
     
    }
}