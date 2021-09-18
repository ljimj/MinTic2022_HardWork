using System;

namespace Salones.App.Dominio
{
    // Esta clase representa un estudiante
    // Hereda de la clase Persona
    public class Estudiante:Persona
    {
        public string carrera{get;set;}

        public string semestre{get;set;}

        public Facultad facultad {get;set;}
        
        
    }
}