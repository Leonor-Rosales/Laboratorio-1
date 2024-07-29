List<double> ProductList = new List<double>();
List<string> NameList = new List<string>();
static void IngresarProductos(List<double> ProductList, List<String> NameList)
{
    Console.Write("Ingrese el nombre del producto: ");
    string nameProducts = Console.ReadLine();
    NameList.Add(nameProducts);
    Console.Write("Ingrese el precio del producto: ");

}