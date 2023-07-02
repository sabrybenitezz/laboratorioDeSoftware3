using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Aplicacion.DTO;
using _02_Dominio;
using _02_Dominio.Repositorio;

namespace _01_Aplicacion
{
    public class EliminarAutomovil
    {
        private AutomovilRepositorio repositorio;

        public EliminarAutomovil(AutomovilRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }


        public void Ejecutar(String Patente)
        {
            this.repositorio.EliminarAutomovil(Patente);
        }
    }
}

