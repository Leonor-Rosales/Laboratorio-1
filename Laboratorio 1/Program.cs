List<double> ProductList = new List<double>();
List<string> NameList = new List<string>();
static void IngresarProductos(List<double> productList, List<String> nameList)
{
    Console.Write("Ingrese el nombre del producto: ");
    string nameProducts = Console.ReadLine();
    nameList.Add(nameProducts);
    Console.Write("Ingrese el precio del producto: ");
    double ProductList = int.Parse(Console.ReadLine());
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
    double subTotal = CalcularPrecios(productList);
    if(subTotal >= 100)
    {
        Console.WriteLine("Se le aplicará un 10% de descuento");
        double total = subTotal - (subTotal*0.1);

    }
}
