using System;
using Salones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Salones.App.Persistencia

{
    public class RepositorioPersonalAseo : IRepositorioPersonalAseo
    {
        private readonly AppContext _appContext;

        public RepositorioPersonalAseo(AppContext appContext)
        {
            _appContext = appContext;
        }

        PersonalAseo IRepositorioPersonalAseo.AddPersonalAseo(PersonalAseo personalAseo)
        {
            
            var personalAseoAdicionado = _appContext.PersonasAseo.Add(personalAseo);
            _appContext.SaveChanges();
            return personalAseoAdicionado.Entity;
        }

        PersonalAseo IRepositorioPersonalAseo.UpdatePersonalAseo(PersonalAseo personalAseo)
        {
            
            var personalAseoEncontrado = _appContext.PersonasAseo.FirstOrDefault(p => p.id == personalAseo.id);
            if (personalAseoEncontrado != null)
            {
                personalAseoEncontrado.nombres = personalAseo.nombres;
                personalAseoEncontrado.apellidos = personalAseo.apellidos;
                personalAseoEncontrado.tipoIdentificacion = personalAseo.tipoIdentificacion;
                personalAseoEncontrado.identificacion = personalAseo.identificacion;
                personalAseoEncontrado.edad = personalAseo.edad;
                personalAseoEncontrado.estadoCovid = personalAseo.estadoCovid;
                personalAseoEncontrado.id = personalAseo.id;
                personalAseoEncontrado.turno = personalAseo.turno;

                _appContext.SaveChanges();
            }
            return personalAseoEncontrado;
        }

        void IRepositorioPersonalAseo.DeletePersonalAseo (int idPersonalAseo)
        {
            var personalAseoEncontrado = _appContext.PersonasAseo.FirstOrDefault(p => p.id == idPersonalAseo);
            if (personalAseoEncontrado == null)
                return;
            _appContext.PersonasAseo.Remove(personalAseoEncontrado);
            _appContext.SaveChanges();
        }

        PersonalAseo IRepositorioPersonalAseo.GetPersonalAseo(int idPersonalAseo)
        {

            var PersonalAseoEncontrado = _appContext.PersonasAseo.FirstOrDefault(p => p.id == idPersonalAseo);
            return PersonalAseoEncontrado;
        }

        IEnumerable<PersonalAseo> IRepositorioPersonalAseo.GetAllPersonasAseo()
        {
            return _appContext.PersonasAseo;
        }
    }
}