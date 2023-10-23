// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 0; i < 80; i++)
{
    Console.WriteLine("Mi curso Avanzado de C#");
}

Console.WriteLine("Ingrese un numero a multiplicar 10 veces");
var numeroMultiplicar=int.Parse(Console.ReadLine()!);
for (int i = 0;i < 10; i++)
{
    int resultado = i * numeroMultiplicar;
    Console.WriteLine( $"{i}* {numeroMultiplicar} = { resultado}");
}

Console.WriteLine("Ingrese un numero");
var numero = int.Parse(Console.ReadLine()!);
while (numero < 100)
{
    Console.WriteLine(numero);
    numero++;
}

