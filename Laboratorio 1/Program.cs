using System.Collections;


static void IngresarProductos(List<double> productList, List<String> nameList)
{
    try
    {
        Console.Write("Ingrese el nombre del producto: ");
        string nameProducts = Console.ReadLine();
        nameList.Add(nameProducts);
        Console.Write("Ingrese el precio del producto: ");
        double ProductList = int.Parse(Console.ReadLine());
    }
    catch (Exception ex)
    {

        Console.WriteLine("Error:" + ex.Message);
    }
}
static double CalcularPrecios(List<double> productList)
{
    double preciosAcumulados=0;
    foreach (double product in productList)
    {
        preciosAcumulados = product;
        preciosAcumulados+= preciosAcumulados;
    }

    return preciosAcumulados;
}
static double CalcularTotal(List<double> productList)
{
    double subTotal = CalcularPrecios(productList), total = 0;
    if(subTotal >= 100)
    {
        Console.WriteLine("Se le aplicará un 10% de descuento");
     total = subTotal - (subTotal*0.1);
    }
    return total;
}
 
static void Menu()
{
    Console.WriteLine("--- Tienda Detroy ---");
    Console.WriteLine("1. Ingresar Productos");
    Console.WriteLine("2. Total a Pagar");
    Console.WriteLine("3. Salir");
    Console.WriteLine("Ingrese la opción deseada");
  
}
try
{
    List<double> ProductList = new List<double>();
    List<string> NameList = new List<string>();
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
            CalcularTotal(ProductList);
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Saliendo");
            return;

        default:
            Console.WriteLine("Ingrese una opón válida")
                break;
    }
}
catch (Exception ex)
{

    Console.WriteLine("Error: " + ex.Message);
}
