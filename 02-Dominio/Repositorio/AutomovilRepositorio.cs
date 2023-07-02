using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.Repositorio
{
    public interface AutomovilRepositorio
    {
        public List<Automovil> obtenerTodos();
        public void grabar(Automovil automovil);

        public void EliminarAutomovil(String Patente);

        public void ActualizarAutomovil(string patente, string marca, string modelo, int precio);   

    }
}
