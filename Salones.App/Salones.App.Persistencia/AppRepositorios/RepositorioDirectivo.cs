using Salones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Salones.App.Persistencia

{
    public class RepositorioDirectivo : IRepositorioDirectivo
    {
        private static AppContext _appContext;

        public RepositorioDirectivo(AppContext appContext)
        {
            _appContext = appContext;
        }

        Directivo IRepositorioDirectivo.AddDirectivo(Directivo directivo)
        {
            
            var directivoAdicionado = _appContext.Directivos.Add(directivo);
            _appContext.SaveChanges();
            //return DirectivoAdicionado;
            return directivoAdicionado.Entity;
        }

        Directivo IRepositorioDirectivo.UpdateDirectivo(Directivo directivo)
        {
            
            var directivoEncontrado = _appContext.Directivos.FirstOrDefault(p => p.id == directivo.id);
            if (directivoEncontrado != null)
            {
                directivoEncontrado.nombres = directivo.nombres;
                directivoEncontrado.apellidos = directivo.apellidos;
                directivoEncontrado.tipoIdentificacion = directivo.tipoIdentificacion;
                directivoEncontrado.identificacion = directivo.identificacion;
                directivoEncontrado.edad = directivo.edad;
                directivoEncontrado.estadoCovid = directivo.estadoCovid;
                directivoEncontrado.unidad = directivo.unidad;

                _appContext.SaveChanges();
            }
            return directivoEncontrado;
        }

        void IRepositorioDirectivo.DeleteDirectivo (int idDirectivo)
        {
            var directivoEncontrado = _appContext.Directivos.FirstOrDefault(p => p.id == idDirectivo);
            if (directivoEncontrado == null)
                return;
            _appContext.Directivos.Remove(directivoEncontrado);
            _appContext.SaveChanges();
        }

        Directivo IRepositorioDirectivo.GetDirectivo(int idDirectivo)
        {

            var DirectivoEncontrado= _appContext.Directivos.FirstOrDefault(p => p.id == idDirectivo);
            return DirectivoEncontrado;
        }

        IEnumerable<Directivo> IRepositorioDirectivo.GetAllDirectivos()
        {
            return _appContext.Directivos;
        }

    }
}