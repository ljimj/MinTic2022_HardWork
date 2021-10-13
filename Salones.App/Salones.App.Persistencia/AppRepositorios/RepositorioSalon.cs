using System;
using Salones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Salones.App.Persistencia

{
    public class RepositorioSalon : IRepositorioSalon
    {
        private static AppContext _appContext;
        IEnumerable<Salon> salones;
        public RepositorioSalon(AppContext appContext)
        {
            _appContext = appContext;
        }

        public RepositorioSalon(IEnumerable<Salon> salones)
        {
            this.salones = salones;
        }

        Salon IRepositorioSalon.AddSalon(Salon salon)
        {
            
            var salonAdicionado = _appContext.Salones.Add(salon);
            _appContext.SaveChanges();
            return salonAdicionado.Entity;
        }

        Salon IRepositorioSalon.UpdateSalon(Salon salon)
        {
            
            var salonEncontrado = _appContext.Salones.FirstOrDefault(p => p.id == salon.id);
            if (salonEncontrado != null)
            {
                salonEncontrado.nombreSalon = salon.nombreSalon;
                salonEncontrado.capacidad = salon.capacidad;
                salonEncontrado.disponibilidad = salon.disponibilidad;
                
                _appContext.SaveChanges();
            }
            return salonEncontrado;
        }

        void IRepositorioSalon.DeleteSalon (int idSalon)
        {
            var salonEncontrado = _appContext.Salones.FirstOrDefault(p => p.id == idSalon);
            if (salonEncontrado == null)
                return;
            _appContext.Salones.Remove(salonEncontrado);
            _appContext.SaveChanges();
        }

        Salon IRepositorioSalon.GetSalon(int idSalon)
        {

            var SalonEncontrado = _appContext.Salones.FirstOrDefault(p => p.id == idSalon);
            return SalonEncontrado;
        }

        IEnumerable<Salon> IRepositorioSalon.GetAllSalones()
        {
            return _appContext.Salones;
        }
    }
}