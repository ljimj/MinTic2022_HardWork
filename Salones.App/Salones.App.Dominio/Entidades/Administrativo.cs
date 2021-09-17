using System;
// Esta clase representa en trabajador administrativo
// Hereda la clase Persona
namespace Salones.App.Dominio
{
    public class Administrativo:Persona
    {
        public string unidad{get;set;}
        public string oficina{get;set;}
        public string dependencia{get;set;}
         
        
    }
}