using System;

namespace Salones.App.Dominio
{
    // Esta clase es la base para listados de personas.
    public class Persona 
    {
        public int id {get;set;}

        public string nombres {get;set;}

        public string apellidos {get;set;}

        public TipoIdentificacion tipoIdentificacion {get;set;}

        public string identificación {get;set;}

        public int edad {get;set;}

        public Covid estadoCovid {get;set;}

    }
}