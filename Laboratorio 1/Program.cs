using System.Collections;
using static System.Net.Mime.MediaTypeNames;


static int IngresarProductos( List<String> nameList, List<double> productList)
{
    int cont = 0;
    try
    {
        
        Console.Write("Ingrese el nombre del producto: ");
        string nameProducts = Console.ReadLine();
        nameList.Add(nameProducts);
        Console.Write("Ingrese el precio del producto: ");
        double priceProducts = int.Parse(Console.ReadLine());
        productList.Add(priceProducts);
        
    }
    catch (Exception ex)
    {

        Console.WriteLine("Error:" + ex.Message);
    }
    cont++;
 return cont;
}
static double CalcularPrecios(List<double> productList)
{
    double preciosAcumulados=0;
    foreach (double product in productList)
    {
        preciosAcumulados = product;
        preciosAcumulados++;
    }

    return preciosAcumulados-1;
}
static double CalcularTotal(List<double> productList)
{
    double subTotal = CalcularPrecios(productList), total = 0;
    if(subTotal >= 100)
    {
        Console.WriteLine("Se le aplicará un 10% de descuento");
     total = subTotal - (subTotal*0.1);
    }
    else
    {
        total = subTotal;
    }
    return total;
}
 
static void Menu()
{
    Console.Clear();
    Console.WriteLine("--- Tienda Detroy ---");
    Console.WriteLine("1. Ingresar Productos");
    Console.WriteLine("2. Total a Pagar");
    Console.WriteLine("3. Salir");
    Console.Write("Ingrese la opción deseada: ");
  
}
List<double> ProductList = new List<double>();
List<string> NameList = new List<string>();
bool run = true;
do
{
    try
    {
       
           Menu();
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.Clear();
                IngresarProductos(NameList, ProductList);
       
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Su total a pagar es: " + CalcularTotal(ProductList));
                Console.WriteLine("El total de productos es de: " + NameList.Count);
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
} while (run = true);