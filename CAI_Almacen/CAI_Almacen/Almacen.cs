using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Almacen
{
    class Almacen
    {
        private float plata;
        Dictionary<Producto, int> inventario = new Dictionary<Producto, int> ();
        List<Transaccion> ventas = new List<Transaccion>();
        List<Transaccion> compras = new List<Transaccion>();

        public Almacen() : this(10000)
        {

        }
        
        public Almacen(float platainicial)
        {
            this.plata = platainicial;
        }
        
        public void SumarStockAlProducto (Producto producto, int cantidad)
        {
            inventario[producto] += cantidad;
            plata -= producto.Costo * cantidad;
        }

        public void VentaProducto(Producto producto, int cantidad, DateTime fecha)
        {
            if (!inventario.ContainsKey(producto)) {
                inventario[producto] = 0;
            }
            if (inventario[producto] >= cantidad)
                {
                    inventario[producto] -= cantidad;
                    plata += producto.Precio * cantidad;
                    ventas.Add(new Transaccion(cantidad, producto, fecha));
                }
                else
                {
                    throw new System.ArgumentException("No se encuentra con stock suficiente para vender " + cantidad + " de: "+ producto.Nombre + ". Disponible " + inventario[producto]);
                }

        }
        public void VentaProducto(Producto producto, int cantidad)
        {
            VentaProducto(producto, cantidad, DateTime.Today);

        }

        public void ComproProducto(Producto producto, int cantidad, DateTime fecha)
        {
            if(inventario.ContainsKey(producto)) {
                inventario[producto] += cantidad;
            }
            else
            {
                inventario[producto] = cantidad;
            }
            plata += producto.Precio * cantidad;
            compras.Add(new Transaccion(cantidad, producto, fecha));


        }
        public void ComproProducto(Producto producto, int cantidad)
        {
            ComproProducto(producto, cantidad, DateTime.Today);

        }
        public float IngresosBrutos()
        {
            return (ventas.Sum (venta => venta.Bruto()) * 0.035f);
        }
        public int ProductoStock(Producto producto)
        {
            return inventario[producto];
        }
        public string DevolverInventario ()
        {
            string texto = "Stock al día " + DateTime.Today.ToShortDateString() + '\n';
            foreach (Producto producto in inventario.Keys)
            {
                texto += producto.Nombre + ": " + inventario[producto] + '\n';
            }
            return texto;
            
        }
        public float Plata
        {
            get
            {
                return this.plata;
            }
        }
    }
}
