using System.Runtime.InteropServices;

Console.WriteLine("Atribuindo Valores para Bool e Char:");
Console.WriteLine("");

//Aqui Temos operadores Booleanos que Retornam um valor Verdadeiro ou Falso, ou seja, True ou False
bool ativo = true;
Boolean inativo = false;


char letra1 = 'A';
char letra2 = '\u0041'; // Unicode para 'A'

byte x = 10;
byte y = 15;

Console.WriteLine("------------------------------");
Console.WriteLine("Valores Boleanos:");
Console.WriteLine("");
Console.WriteLine("Ativo: " + ativo);
Console.WriteLine("Inativo: " + inativo);
Console.WriteLine("------------------------------");
Console.WriteLine("Comparando Valores:");
Console.WriteLine("");
Console.WriteLine("10 é Igual a 15: "+ (10 == 15));
Console.WriteLine("10 é Igual a 10: "+ (10 == 10));
Console.WriteLine("------------------------------");
Console.WriteLine("Comparando Valores Por Variavel:");
Console.WriteLine("");
Console.WriteLine("A variavel x (" + x + ") E maior que a y (" + y + ")? " + (x > y));
Console.WriteLine("------------------------------");
Console.WriteLine("Valores Char:");
Console.WriteLine("");
Console.WriteLine("Letra 1: " + letra1);
Console.WriteLine("Letra 2 Com Representação Unicode: " + letra2);
Console.WriteLine("------------------------------");

Console.ReadLine();