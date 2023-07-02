using _01_Aplicacion.DTO;
using _02_Dominio;
using _02_Dominio.Repositorio;

namespace _01_Aplicacion
{
    public class CrearAutomovil
    {
        private AutomovilRepositorio repositorio;

        public CrearAutomovil(AutomovilRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void ejecutar(AutomovilDTO automovil)
        {
            this.repositorio.grabar(new Automovil(automovil.Id(), automovil.Marca(), automovil.Modelo(), automovil.Precio()));
        }

    }
}