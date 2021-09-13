using System.Runtime.Serialization;
using System;

namespace Salones.App.Dominio
{
    public class Covid
    {
        public string sintomas{get;set;}
        public DateTimeFormat fechaDiagnostico{get;set;}
        public string resultado{get;Set;}
    }
}