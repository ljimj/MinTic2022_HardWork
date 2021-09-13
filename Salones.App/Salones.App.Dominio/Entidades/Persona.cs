using System;

namespace Salones.App.Dominio
{
    public class Persona 
    {
        public string nombres{get;set;}
        public string apellidos{get;set;}
        public indentificaion identificacion{get;set;}
        public int edad{get;set;}
        public boolean estadoCOVID{get;set;}
        public int aislamiento{get;set;}
    }
}