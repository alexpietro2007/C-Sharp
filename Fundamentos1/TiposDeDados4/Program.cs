Console.WriteLine("Definindo variáveis do tipo String, Object e Dynamic");
Console.WriteLine("");

//String pode Ser Declarada com a letra "s" minuscula ou com a letra "S" maiuscula, ambas são equivalentes
string nome = "Curso C#";
String titulo = "Curso C# essencial";

/*Quando o valor de uma variavel do tipo string e criaado com um valor quando
alterado ele não é alterado e sim criado um novo valor,
ou seja, a variavel do tipo string é imutavel, ou seja,
ela não pode ser alterada depois de criada, mas sim criar um novo valor para a variavel.
Mas o Garbage Collector é responsável por limpar os valores antigos que não são mais referenciados.*/
string valor = "Isto é uma string";
valor = "Isto é uma string alterada";
valor = "teste";

//Object é um coringa que aceita todos os tipos de dados
object nota = 10;
object valor1 = 8.55m;
object nome1 = "Maria";
object ativa = true;
object letra = 'A';

/*Dynamic é a mesma coisa do object, a diferencia e que o dynamic e para usar recursos avançados do C#,
como por exemplo, o uso de bibliotecas externas, onde o tipo de dado pode ser desconhecido em tempo de compilação,
ou seja, ele é resolvido em tempo de execução, ou seja, ele é dinâmico.*/
dynamic nota2 = 10;
dynamic valor2 = 8.55m;
dynamic nome2 = "Maria";
dynamic ativa2 = true;
dynamic letra2 = 'A';

Console.WriteLine("------------------------------");
Console.WriteLine("Mostrando Variáveis do tipo String:");
Console.WriteLine("");
Console.WriteLine("Valor da Variável nome: " + nome);
Console.WriteLine("Valor da Variável titulo: " + titulo);
Console.WriteLine("------------------------------");
Console.WriteLine("Mostrando Variáveis do tipo Object:");
Console.WriteLine("");
Console.WriteLine("Valor da Variável nota: " + nota);
Console.WriteLine("Valor da Variável valor1: " + valor1);
Console.WriteLine("Valor da Variável nome1: " + nome1);
Console.WriteLine("Valor da Variável ativa: " + ativa);
Console.WriteLine("Valor da Variável letra: " + letra);
Console.WriteLine("------------------------------");
Console.WriteLine("Mostrando Variáveis do tipo Dynamic:");
Console.WriteLine("");
Console.WriteLine("Valor da Variável nota2: " + nota2);
Console.WriteLine("Valor da Variável valor2: " + valor2);
Console.WriteLine("Valor da Variável nome2: " + nome2);
Console.WriteLine("Valor da Variável ativa2: " + ativa2);
Console.WriteLine("Valor da Variável letra2: " + letra2);
Console.WriteLine("------------------------------");