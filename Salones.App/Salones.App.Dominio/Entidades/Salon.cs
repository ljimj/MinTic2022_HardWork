using System;

namespace Salones.App.Dominio
{
    public class Salon
    {
        public int id {get;set;}

        public int capacidad {get;set;}

        public bool disponibilidad{get;set;}

        public System.Collections.Generic.List<Persona> personasSalon {get;set;} 

       
    }
}