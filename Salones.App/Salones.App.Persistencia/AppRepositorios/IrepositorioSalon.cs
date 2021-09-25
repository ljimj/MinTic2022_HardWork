using System.Collections.Generic;
using Salones.App.Dominio;

namespace Salones.App.Persistencia
{
    public interface IRepositorioSalon
    {
         //CRUD
        //GetAllSalones
        IEnumerable<Salon> GetAllSalones();
        //AddSalon
        Salon AddSalon(Salon salon);
        //updateSalon
        Salon UpdateSalon(Salon salon);
        //DeleteSalon
        void DeleteSalon(int idSalon);
        //GetSalon
        Salon GetSalon(int idSalon);
    }

}    