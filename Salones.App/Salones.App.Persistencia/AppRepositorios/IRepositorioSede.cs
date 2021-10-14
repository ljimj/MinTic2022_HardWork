using System.Collections.Generic;
using Salones.App.Dominio;

namespace Salones.App.Persistencia
{
    public interface IRepositorioSede
    {
        //CRUD
        //GetAllSalones
        IEnumerable<Sede> GetAllSedes();
        //AddSalon
        Sede AddSede(Sede sede);
        //updateSalon
        Sede UpdateSede(Sede Sede);
        //DeleteSalon
        void DeleteSede(int idSede);
        //GetSalon
        Sede GetSede(int idSede);
        //GetAllSedes 
        IEnumerable<Sede> GetAllSedesConSalonesDisponibles(bool disponibilidad);
   
    }
}