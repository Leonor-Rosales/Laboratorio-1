using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_POO
{
    internal class Producto
    {
        public List<string> Nombre { get; set; }
        public List<double> Precio { get; set; }
        public List<int> Stock { get; set; }

        public Producto(List<string> nombre, List<double> precio, List<int> stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public void IngresarProducto(List<string> namePoduct, List<double> priceProduct, List<int> stock) 
        {
            try
            {

                Console.Write("Ingrese el nombre del producto: ");
                string nameProducts = Console.ReadLine();
                namePoduct.Add(nameProducts);
                Console.Write("Ingrese el precio del producto: ");
                double priceProducts = int.Parse(Console.ReadLine());
                priceProduct.Add(priceProducts);
                Console.Write("Ingrese la cantidad del producto: ");
                int stockProducts = int.Parse(Console.ReadLine());
                stock.Add(stockProducts);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error:" + ex.Message);
            }

        }

    }
    
}
