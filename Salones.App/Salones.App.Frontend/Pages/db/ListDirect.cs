using Salones.App.Persistencia;
using Salones.App.Dominio;
using System;
using System.Collections.Generic;

namespace Salones.App.Frontend
{
    
    public class ListDirect {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        
        public static IEnumerable<Directivo> getAll()
        {
            IEnumerable<Directivo> directivos = _repoDirectivo.GetAllDirectivos();
            
            return directivos;
            
        }

    }

}