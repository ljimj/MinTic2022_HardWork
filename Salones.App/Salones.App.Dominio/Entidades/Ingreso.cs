using System;
using System.Runtime.Serialization;

namespace Salones.App.Dominio

{
    public class Ingreso
    {
        public int id {get;set;}         //Id del registro de ingreso

        public DateTime FechaIngreso {get; set;}

        public Salon salon {get;set;}

        public System.Collections.Generic.List<Persona> personasSalon {get;set;} 
        
     }
}