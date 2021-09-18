using System;

namespace Salones.App.Dominio
{
    // Esta clase es la base para listados de personas.
    public class Persona 
    {
        public string nombres{get;set;}
        public string apellidos{get;set;}
        public Identificacion identificacion{get;set;}
        public int edad{get;set;}
        public bool estadoCOVID{get;set;}
        public int aislamiento{get;set;}
    }
}