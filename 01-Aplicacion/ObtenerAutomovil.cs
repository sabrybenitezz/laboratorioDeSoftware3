using _01_Aplicacion.DTO;
using _02_Dominio;
using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class ObtenerAutomovil
    {
        private AutomovilRepositorio repositorio;

        public ObtenerAutomovil(AutomovilRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<AutomovilDTO> ejecutar()
        {
            List<Automovil> automoviles = this.repositorio.obtenerTodos();
            List<AutomovilDTO> automovilesDTO = new List<AutomovilDTO>();
            foreach (Automovil automovil in automoviles)
            {
                AutomovilDTO automovilDTO = new AutomovilDTO(automovil.Id(), automovil.Marca(), automovil.Modelo(), automovil.Precio());
                automovilesDTO.Add(automovilDTO);
            }
            return automovilesDTO;
        }
    }
}
