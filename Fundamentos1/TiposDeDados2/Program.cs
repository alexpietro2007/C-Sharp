using System.Diagnostics;

Console.WriteLine("Atribuindo Valores a Double, Float e Decimal:");
Console.WriteLine("");

//Double n Precisa de sufixo, pois o valor é do tipo double por padrão
double n1 = 1.234;

//Float n Precisa de sufixo "f" para indicar que é do tipo float
float n2 = 1.234f;

//Decimal Precisa de sufixo "m" para indicar que é do tipo decimal
decimal n3;
n3 = 1.234m;

//Aqui Serve para Comparar a Precisão de cada Tipo Decimal, pois o valor é o mesmo, mas a precisão é diferente
float x = 1.0f / 3.0f;
double y = 1.0 / 3.0;
decimal z = 1.0m / 3.0m;


Console.WriteLine("------------------------------");
Console.WriteLine("Valores Sendo definido na variavel:");
Console.WriteLine("");
Console.WriteLine("Valor do Double: " + n1);
Console.WriteLine("Valor do Float: " + n2);
Console.WriteLine("------------------------------");
Console.WriteLine("Valor sendo definido Após:");
Console.WriteLine("");
Console.WriteLine("Valor do Decimal: " + n3);
Console.WriteLine("------------------------------");

Console.ReadLine();

Console.WriteLine("Comparando a precisão de Float, Double e Decimal");


Console.WriteLine("------------------------------");
Console.WriteLine("Precisão de cada Tipo Decimal:");
Console.WriteLine("");
Console.WriteLine("Valor de Precisão do Float: " + x);
Console.WriteLine("Valor de Precisão do Double: " + y);
Console.WriteLine("Valor de Precisão do Decimal: " + z);
Console.WriteLine("------------------------------");

Console.ReadLine();