using System;
using System.Collections.Generic;

namespace Salones.App.Dominio
{
    public class Sede
    {
        public int id {get;set;}

        public int cantidadSalones {get;set;}

        public System.Collections.Generic.List<Salon> salones {get;set;}

        public System.Collections.Generic.List<Persona> personasAutorizadas {get;set;} 

        //Incluir arreglo de los salones de la sede
        //Como se maneja el horario?
    }
}