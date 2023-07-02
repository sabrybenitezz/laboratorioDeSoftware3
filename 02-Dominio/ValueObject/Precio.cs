using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class ValorAceptable
    {
        private int valor;

        public ValorAceptable(int valor)
        {
            this.DebeSerMayorACienMil(valor);
            this.valor = valor;
        }
        public int Valor()
        {
            return this.valor;
        }
        private void DebeSerMayorACienMil(int valor)
        {
            if (valor < 100000)
            {
                throw new Exception("El precio debe de ser mayor a $100.000");
            }
        }
    }
}
