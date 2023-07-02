using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class ActualizarAutomovil
    {
        private AutomovilRepositorio repositorio;
        public ActualizarAutomovil(AutomovilRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void ejecutar(String Patente, String Marca, String Modelo, int Precio)
        {
            this.repositorio.ActualizarAutomovil(Patente, Marca, Modelo, Precio);
        }
    }
}





    

