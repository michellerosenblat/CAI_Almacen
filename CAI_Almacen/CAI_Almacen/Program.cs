using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Almacen
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacen mialmacen = new Almacen(20000);
            Producto fideos = new Producto("fideos", 10, 5);
            Producto arroz = new Producto("arroz", 10, 5);
            Producto zapallitos = new Producto("zapallitos", 80, 5);
            mialmacen.ComproProducto(arroz, 5);
            mialmacen.ComproProducto(zapallitos, 5);
            try
            {
                mialmacen.VentaProducto(fideos, 20);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            try {
                mialmacen.VentaProducto(arroz, 20);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            mialmacen.VentaProducto(arroz, 5);

            Console.WriteLine("El stock de " + arroz.Nombre + " es: " + mialmacen.ProductoStock (arroz));
            Console.WriteLine("Lo que tenes que pagar de Ingresos Brutos es: " + mialmacen.IngresosBrutos());
            Console.WriteLine(mialmacen.DevolverInventario());
            Console.WriteLine("La plata del almacen es: " + mialmacen.Plata);
            
            Console.ReadLine();
        }
    }
}
