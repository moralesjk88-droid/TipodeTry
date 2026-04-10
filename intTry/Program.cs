// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese cantidad de libros");
int libro;
if (int.TryParse(Console.ReadLine(),out libro))
{
    if (libro<0)
    {
        Console.WriteLine("No es un numero valido");
    }
    else
    {
        Console.WriteLine("Cantidad guardada");
    }
}
else
{
    Console.WriteLine("Error número no valido");  
}




