using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Almacen
{
    class Transaccion
    {
        private int cantidad;
        private Producto producto;
        private DateTime fecha;

        public Transaccion (int cantidad, Producto producto, DateTime fecha)
        {
            this.cantidad = cantidad;
            this.producto = producto;
            this.fecha = fecha;
        }
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }
        public Producto Producto
        {
            get
            {
                return this.producto;
            }
            set
            {
                this.producto = value;
            }
        }
        public float Bruto()
        {
            return this.producto.Precio * this.cantidad;
        }
    }
}
