using System.Collections.Generic;
using Salones.App.Dominio;

namespace Salones.App.Persistencia
{
    public interface IRepositorioPersonalAseo
    {
         //CRUD
        //GetAllPersonasAseo
        IEnumerable<PersonalAseo> GetAllPersonasAseo();
        //AddPersonalAseo
        PersonalAseo AddPersonalAseo(PersonalAseo personalAseo);
        //updatePersonalAseo
        PersonalAseo UpdatePersonalAseo(PersonalAseo personalAseo);
        //DeletePersonalAseo
        void DeletePersonalAseo(int idPersonalAseo);
        //GetPersonalAseo
        PersonalAseo GetPersonalAseo(int idPersonalAseo);
    }

}    