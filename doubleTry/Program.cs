// See https://aka.ms/new-console-template for more information
  double precio;
do
{
    Console.Clear();
 Console.WriteLine("Ingrese el precio del producto");
  
    if (double.TryParse(Console.ReadLine(), out precio)) 
    {
        Console.WriteLine("Precio guardado");
        Console.ReadKey();
    }
    else
    {
Console.WriteLine("PRECIO NO VALIDO");
        Console.ReadKey();
    }
        
}
while (precio<0);