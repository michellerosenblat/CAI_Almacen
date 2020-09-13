using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Almacen
{
    class Producto
    {
        private float precio;
        private string nombre;
        private float costo;

        public Producto(string nombre, float precio, float costo)
        {
            this.precio = precio;
            this.nombre = nombre;
            this.costo = costo;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        public float Costo
        {
            get
            {
                return this.costo;
            }
            set
            {
                this.costo = value;
            }
        }
    }
}
