// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using PrograI_Semana4.Entidades;
using PrograI_Semana4.Negocios;

ContadorDeLetras contadordeletras = new ContadorDeLetras();
ClsContadorDeLetras clscontadorletras = new ClsContadorDeLetras();

Console.WriteLine("Introduce una frase: ");
String hola = Console.ReadLine();

contadordeletras.texto = hola;

int resultado = clscontadorletras.contadores(contadordeletras);

Console.WriteLine($"La cantidad de letras de tu frase es: {resultado}");