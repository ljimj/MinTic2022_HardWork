using System;

namespace Salones.App.Dominio

{
    public class Ingreso{
        int id;          //Id del registro de ingreso
        DateTime FechaIngreso {get; set;}
        int idPersona {get; set;}
        int idSalon {get; set;}
     }
}