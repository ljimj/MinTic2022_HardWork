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
        //GetAllSedes con estado de disponibilidad
        IEnumerable<Sede> GetAllSedesConSalonesDisponibles(bool disponibilidad);
        //GetAllSedes Con personas mayores de 60
        IEnumerable<Sede> GetAllSedesPersonasMayores();

        //GEtAllSedes con personas covid

        IEnumerable<Sede> GetAllSedesPersonasCovid();
   
    }
}