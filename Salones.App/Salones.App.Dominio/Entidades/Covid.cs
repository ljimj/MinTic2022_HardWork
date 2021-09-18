using System.Runtime.Serialization;
using System;

namespace Salones.App.Dominio
{
    //Estado COVID de una persona
    public class Covid
    {         
        public int id {get;set;}
        
        public string sintomas{get;set;}

        public EstadoCovid estadoCovid {get;set;}

        public string fechaDiagnostico{get;set;}

        public string periodoAislamiento {get;set;}
    }
}