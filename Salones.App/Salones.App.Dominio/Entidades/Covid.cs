using System.Runtime.Serialization;
using System;

namespace Salones.App.Dominio
{
    //Estado COVID de una persona

    // hereda de persona o persona hereda de covid
    public class Covid
    {         
        public int id {get;set;}
        
        public string sintomas{get;set;}

        public EstadoCovid estadoCovid {get;set;} //este no seria bool
        
        public string fechaDiagnostico{get;set;}

        public string periodoAislamiento {get;set;}
    }
}