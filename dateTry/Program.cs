// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DateTime fecha;
bool contar;
do
{
    Console.WriteLine("ingrese la fecha:_ ");
    contar=DateTime.TryParse(Console.ReadLine(), out fecha);
    if (!contar)
    {
        Console.Write("ERROR DE FECHA");
    }
    else
    {
        Console.WriteLine("Fecha correcta");
    }


}
while (!contar);



//probar con datetime.tryparse