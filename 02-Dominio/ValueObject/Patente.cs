using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Patente
    {
        private String dato;

        public Patente(string dato)
        {
            this.DebeTenerSintaxisValida(dato);
            this.dato = dato;
        }

        public String Dato()
        {
            return this.dato;
        }

        private void DebeTenerSintaxisValida(String dato)
        {
            var pattern = @"^[A-Z]{3}\d{3}$";
            var regex = new Regex(pattern);
            if (!regex.IsMatch(dato))
            {
                throw new Exception("La patente no es válida.");
            }
        }
    }
}
