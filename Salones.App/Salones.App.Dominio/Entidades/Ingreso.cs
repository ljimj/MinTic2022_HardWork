using System;
using System.Runtime.Serialization;

namespace Salones.App.Dominio

{
    public class Ingreso
    {
        public int id {get;set;}         //Id del registro de ingreso

        public string FechaIngreso {get; set;}

        public Persona persona {get; set;}

        public Salon salon {get;set;}
        
     }
}