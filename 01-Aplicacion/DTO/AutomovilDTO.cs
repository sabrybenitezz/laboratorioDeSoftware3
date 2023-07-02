using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion.DTO
{
    public class AutomovilDTO
    {
        private String id;
        private String marca;
        private String modelo;
        private int precio;

        public AutomovilDTO(String id, String marca, String modelo, int precio)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
        }

        public String Id()
        {
            return this.id;
        }
        public String Marca()
        {
            return this.marca;
        }
        public String Modelo()
        {
            return this.modelo;
        }
        public int Precio()
        {
            return this.precio;
        }

        public String presentacion()
        {
            return "Se creo el Automovil  " + "\n" + "Marca: " + this.marca + "\n" + "Modelo: " + this.modelo + "\n" + "Precio: $" + this.precio + "\n" + "Con Numero de Patente: " + this.id + "\n";
        }

    }
}
