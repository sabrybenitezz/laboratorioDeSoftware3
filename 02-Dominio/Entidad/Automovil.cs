using _02_Dominio.ValueObject;
using System.Text.RegularExpressions;

namespace _02_Dominio
{
    public class Automovil
    {
        private Patente id;
        private Marca marca;
        private Modelo modelo;
        private ValorAceptable precio;


        public Automovil(
            String id,
            String marca,
            String modelo,
            int precio  
        )
        {
            this.id = new Patente(id);
            this.marca = new Marca(marca);
            this.modelo = new Modelo(modelo);
            this.precio = new ValorAceptable(precio);
        }

        public String Id()
        {
            return this.id.Dato();
        }
        public String Marca()
        {
            return this.marca.Valor();
        }
        public String Modelo()
        {
            return this.modelo.Valor();
        }
        public int Precio()
        {
            return this.precio.Valor();
        }

        public void cambiarMarca(String nuevoNombre)
        {
            this.marca = new Marca(nuevoNombre);
        }

        public String presentacion()
        {
            return "Se creó el automovil Marca:" + this.marca.Valor() + ", Modelo: " + this.modelo.Valor() + " Precio: $" + this.precio.Valor() + " Con Numero de Patente: " + this.id.Dato() ;
        }
        
    }
}