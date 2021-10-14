using Salones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Salones.App.Persistencia

{
    public class RepositorioCovid : IRepositorioCovid
    {
        private readonly AppContext _appContext;

        public RepositorioCovid(AppContext appContext)
        {
            _appContext = appContext;
        }

        Covid IRepositorioCovid.AddCovid(Covid covid)
        {
            
            var covidAdicionado = _appContext.DiagnosticosCovid.Add(covid);
            _appContext.SaveChanges();
            //return CovidAdicionado;
            return covidAdicionado.Entity;
        }

        Covid IRepositorioCovid.UpdateCovid(Covid covid)
        {
            
            var covidEncontrado = _appContext.DiagnosticosCovid.FirstOrDefault(p => p.id == covid.id);
            if (covidEncontrado != null)
            {
                covidEncontrado.sintomas = covid.sintomas;
                covidEncontrado.estadoCovid = covid.estadoCovid;
                covidEncontrado.fechaDiagnostico = covid.fechaDiagnostico;
                covidEncontrado.periodoAislamiento = covid.periodoAislamiento;
                
                _appContext.SaveChanges();
            }
            return covidEncontrado;
        }

        void IRepositorioCovid.DeleteCovid (int idCovid)
        {
            var covidEncontrado = _appContext.DiagnosticosCovid.FirstOrDefault(p => p.id == idCovid);
            if (covidEncontrado == null)
                return;
            _appContext.DiagnosticosCovid.Remove(covidEncontrado);
            _appContext.SaveChanges();
        }

        Covid IRepositorioCovid.GetCovid(int idCovid)
        {

            var CovidEncontrado= _appContext.DiagnosticosCovid.FirstOrDefault(p => p.id == idCovid);
            return CovidEncontrado;
        }

        IEnumerable<Covid> IRepositorioCovid.GetAllDiagnosticosCovid()
        {
            return _appContext.DiagnosticosCovid;
        }
        
    }
}