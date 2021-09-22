using System.Collections.Generic;
using Salones.App.Dominio;

namespace Salones.App.Persistencia
{
    public interface IRepositorioDirectivo
    {
        //GetAllDirectivos
        IEnumerable<Directivo> GetAllDirectivos();
        //AddDirectivo
        Directivo AddDirectivo(Directivo directivo);
        //UpdateDirectivo
        Directivo UpdateDirectivo(Directivo directivo);
        //DeleteDirectivo
        void DeleteDirectivo(int idDirectivo);
        //GetDirectivo
        Directivo GetDirectivo(int idDirectivo);
    }
}