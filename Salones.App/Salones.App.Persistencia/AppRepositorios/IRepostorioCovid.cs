using System.Collections.Generic;
using Salones.App.Dominio;

namespace Salones.App.Persistencia
{
    public interface IRepositorioCovid
    {
        //GetAllDiagnosticosCovid
        IEnumerable<Covid> GetAllDiagnosticosCovid();
        //AddCovid
        Covid AddCovid(Covid covid);
        //UpdateCovid
        Covid UpdateCovid(Covid covid);
        //DeleteCovid
        void DeleteCovid(int idCovid);
        //GetCovid
        Covid GetCovid(int idCovid);
    }
}