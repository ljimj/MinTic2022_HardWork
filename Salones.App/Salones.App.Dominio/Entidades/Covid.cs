using System.Runtime.Serialization;
using System;

namespace Salones.App.Dominio
{
    //Estado COVID de una persona

    // 
    public class Covid
    {         
        public int id {get;set;}
        
        public bool sintomas {get;set;}

        public TipoSintomas tipoSintomas {get;set;}

        public bool estadoCovid {get;set;} 
        
        public DateTime fechaDiagnostico{get;set;}

        public int periodoAislamiento {get;set;} //cantidad de dias

    }
}