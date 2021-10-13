using System;
using Salones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Salones.App.Persistencia
{
    public class RepositorioSede : IRepositorioSede
    {
        private static AppContext _appContext;

        public RepositorioSede(AppContext appContext)
        {
            _appContext = appContext;
        }

        Sede IRepositorioSede.AddSede(Sede sede)
        {
            
            var sedeAdicionado = _appContext.Sedes.Add(sede);
            _appContext.SaveChanges();
            return sedeAdicionado.Entity;
        }

        Sede IRepositorioSede.UpdateSede(Sede sede)
        {
            
            var sedeEncontrado = _appContext.Sedes.FirstOrDefault(p => p.id == sede.id);
            if (sedeEncontrado != null)
            {
                sedeEncontrado.salones = sede.salones;
                sedeEncontrado.personasAutorizadas = sede.personasAutorizadas;
                
                _appContext.SaveChanges();
            }
            return sedeEncontrado;
        }

        void IRepositorioSede.DeleteSede (int idSede)
        {
            var sedeEncontrado = _appContext.Sedes.FirstOrDefault(p => p.id == idSede);
            if (sedeEncontrado == null)
                return;
            _appContext.Sedes.Remove(sedeEncontrado);
            _appContext.SaveChanges();
        }

        Sede IRepositorioSede.GetSede(int idSede)
        {

            var SedeEncontrado = _appContext.Sedes.FirstOrDefault(p => p.id == idSede);
            return SedeEncontrado;
        }

        IEnumerable<Sede> IRepositorioSede.GetAllSedes()
        {
            return _appContext.Sedes;
        }
    }
}