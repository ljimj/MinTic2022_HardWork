using System;
using Salones.App.Dominio;
using Salones.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace Salones.App.Consola
{
    class Program
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddDirectivo();  //Por si se desea ejecutar
            //BuscarDirectivo(1); //Por si se desea ejecutar
            //ActualizarDirectivo(); //Por si se desea ejecutar
            //EliminarDirectivo(1); //Por si se desea ejecutar
            //BuscarDirectivos(); //Por si se desea ejecutar
        }
        //AddDirectivo
        private static void AddDirectivo()
        {
            var directivo = new Directivo 
            {
                nombres = "Carlos Mario",
                apellidos = "Aponte Guerra",
                tipoIdentificacion = TipoIdentificacion.CC,
                identificacion = "79678543",
                edad = 47,
                estadoCovid = null,
                unidad = "304",
            };

            Console.WriteLine(directivo.nombres+" "+directivo.apellidos+" \n-Unidad: "+ directivo.unidad);
            Directivo directivo_retornado = _repoDirectivo.AddDirectivo(directivo);
            if (directivo_retornado!=null)
                Console.WriteLine("Se registro un Directivo en la base de datos");
        }
        //GetDirectivo
        private static void BuscarDirectivo(int idDirectivo)
        {
            var directivo = _repoDirectivo.GetDirectivo(idDirectivo);
            Console.WriteLine(directivo.nombres+" "+directivo.apellidos+"\n-Unidad: "+directivo.unidad+"\n-Identificación: "+directivo.identificacion);
        }
        //DeleteDirectivo
        private static void EliminarDirectivo(int idDirectivo)
        {
            _repoDirectivo.DeleteDirectivo(idDirectivo);
        }
        //UpdateDirectivo
        private static void ActualizarDirectivo()
        {
            var directivo = new Directivo 
            {
               id = 1,
               nombres = "Carlos Mario",
               apellidos = "Aponte Guerra",
               tipoIdentificacion = TipoIdentificacion.CC,
               identificacion = "86789543",
               edad = 53,
               estadoCovid = null,
               unidad = "507",
            };
            Directivo directivo_retornado =_repoDirectivo.UpdateDirectivo(directivo);                         
            if (directivo_retornado!=null)
                Console.WriteLine("Se actualizó un directivo en la base de datos");
        
        }
        //GetAllDirectivos
        private static void BuscarDirectivos()
        {
            IEnumerable<Directivo> directivos = _repoDirectivo.GetAllDirectivos();
            
            foreach (var directivo in directivos)
            {
                Console.WriteLine(directivo.nombres);
            }
            
        }
        
    }
}
