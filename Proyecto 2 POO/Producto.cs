using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_POO
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Producto(string nombre, double precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public Producto(List<Producto> productList)
        {
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("--- Menú Principal");
            Console.WriteLine("1. Ingresar Productos");
            Console.WriteLine("2. Consultar Información");
            Console.WriteLine("3. Venta de Producto");
            Console.WriteLine("4. Reabastecer el Stock");
            Console.WriteLine("5. Actualizar el Precio");
            Console.WriteLine("6. Salir");
            Console.Write("Ingresa la opción deseada: ");
        }
        public void IngresarProducto(List<Producto> productList)
        {
            try
            {

                Console.Write("Ingrese el nombre del producto: ");
                string nameProducts = Console.ReadLine();
                Console.Write("Ingrese el precio del producto: ");
                double priceProducts = int.Parse(Console.ReadLine());
                if  (priceProducts > 0)
                {
                    Console.Write("Ingrese la cantidad del producto: ");
                    int stockProducts = int.Parse(Console.ReadLine());
                    if (stockProducts > 0)
                    {
                        Producto productFind = productList.Find(p => p.Nombre == nameProducts);
                        if (productFind == null)
                        {
                            productList.Add(new Producto(nameProducts, priceProducts, stockProducts));
                            Console.WriteLine("\nProducto Añadido Correctamente");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n[!] Producto Existente");
                        }
                    }
                    else
                    {
                        Console.WriteLine("[!] Error: Ingrese un valor mayor a 0");
                    }
                    
                }
                else
                {
                    Console.WriteLine("[!] Error: Ingrese un valor mayor a 0");
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error:" + ex.Message);
            }
        }
        public void ConsultarInfo(List<Producto> productList)
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nameProducts = Console.ReadLine();
            Producto productFind = productList.Find(p => p.Nombre == nameProducts);
            if (productFind != null)
            {
                Console.WriteLine($"Nombre: {productFind.Nombre}\nPrecio: {productFind.Precio}\nCantidad: {productFind.Stock}");
                Console.WriteLine("");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n[!] Producto Inexistente");
            }
        }
        public void VentaProducto(List<Producto> productList)
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nameProducts = Console.ReadLine();
            Producto productFind = productList.Find(p => p.Nombre == nameProducts);
            if (productFind != null)
            {
                int stock = int.Parse(Console.ReadLine());
                Console.Write("Cantidad: ");
                if (stock <= 0)
                {
                    Console.WriteLine("[!] Error: Ingrese un valor mayor a 0");
                }
                else
                {
                    if (productFind.Stock > 0)
                    {
                        productFind.Stock -= stock;
                        Console.WriteLine("\nProducto Vendido Correctamente");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\n[!] Producto Agotado");
                    }
                }
            }
            else
            {
                Console.WriteLine("\n[!] Producto Inexistente");
            }
        }

        public void ReabastecerStock(List<Producto> productList)
        {
            try
            {
                Console.Write("Ingrese el nombre del producto: ");
                string nameProducts = Console.ReadLine();
                Producto productFind = productList.Find(p => p.Nombre == nameProducts);
                if (productFind != null)
                {
                    Console.Write("Cantidad a Ingresar: ");
                    int stock = int.Parse(Console.ReadLine());
                    if (stock <= 0)
                    {
                        Console.WriteLine("[!] Error: Ingrese un valor mayor a 0");
                    }
                    else
                    {
                        productFind.Stock += stock;
                        Console.WriteLine("\nStock Del Producto Actualizado Correctamente");
                        Console.ReadKey();
                    }                
                }
                else
                {
                    Console.WriteLine("\n[!] Producto Inexistente");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("[!] Error: " + ex.Message);
            }
        }
        public void ActualizarPrecio(List<Producto> productList)
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nameProducts = Console.ReadLine();
            Producto productFind = productList.Find(p => p.Nombre == nameProducts);
            if (productFind != null)
            {
                Console.Write("Precio a Ingresar: ");
                int price = int.Parse(Console.ReadLine());
                if (price <= 0)
                {
                    Console.WriteLine("[!] Error: Ingrese un valor mayor a 0");
                }
                else
                {
                    productFind.Precio = price;
                    Console.WriteLine("\nPrecio Del Producto Actualizado Correctamente");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("\n[!] Producto Inexistente");
            }
        }

    }

}

