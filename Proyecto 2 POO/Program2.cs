
using Proyecto_2_POO;

List<Producto> ProductList = new List<Producto>();

Producto productoObjeto = new Producto(ProductList);

bool run = true;
do
{
    try
    {

        productoObjeto.Menu();
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.Clear();
                productoObjeto.IngresarProducto(ProductList);

                break;
            case 2:
                Console.Clear();
                productoObjeto.ConsultarInfo(ProductList);
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Saliendo");
                Console.ReadKey();
                run = false;
                break;

            default:
                Console.WriteLine("Ingrese una opón válida");
                break;
        }
    }
    catch (Exception ex)
    {

        Console.WriteLine("Error: " + ex.Message);
    }
} while (run = true)