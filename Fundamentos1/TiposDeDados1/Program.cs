Console.WriteLine("Declarando Variáveis Numéricas");
Console.WriteLine("");
//Declaração de variáveis numéricas
byte valor1 = 255;
sbyte valor2 = -127;
int valor3 = -2147483647;
valor3 = 1000;
uint valor4 = 4294967295;
long valor5 = -2147483649;

//Constantes
const int valor6 = 999;
// valor6 = 1000

//Criação de variaveis numéricas na mesma linha
int var1 = 8, var2 = 9, var3 = 10;

Console.WriteLine("------------------------------");
Console.WriteLine("Variaveis Numericas:");
Console.WriteLine("Valor 1: " + valor1);
Console.WriteLine("Valor 2: " + valor2);
Console.WriteLine("Valor 3: " + valor3);
Console.WriteLine("Valor 4: " + valor4);
Console.WriteLine("Valor 5: " + valor5);
Console.WriteLine("------------------------------");
Console.WriteLine("Constante quando Declarada n pode ser Alterada:");
Console.WriteLine("Valor 6: " + valor6);
Console.WriteLine("------------------------------");
Console.WriteLine("Conseguimos Declarar mais de uma variavel do mesmo tipo na mesma linha:");
Console.WriteLine("Var 1: " + var1);
Console.WriteLine("Var 2: " + var2);
Console.WriteLine("Var 3: " + var3);
Console.WriteLine("------------------------------");

Console.ReadLine();