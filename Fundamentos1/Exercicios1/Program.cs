Console.WriteLine("EXERCICIOS 1\n");

//1
Console.WriteLine("------------------------------");
Console.WriteLine("1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor\n");
byte idade = 35;
Console.WriteLine($"A idade é: {idade}");
Console.WriteLine("------------------------------");

//2
Console.WriteLine("2- Crie uma variável chamada nome e atribua o valor \"Maria\" e exiba o seu valor\n");
string nome = "Maria";
Console.WriteLine($"O nome é: {nome}");
Console.WriteLine("------------------------------");

//3
Console.WriteLine("3- Crie uma variável chamada altura e atribua a ela o valor 3.45\n");
float altura = 3.45f;
Console.WriteLine($"A altura é: {altura}");
Console.WriteLine("------------------------------");

//4
Console.WriteLine("4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.\n");
DateTime data = new DateTime(1999,09,04);
Console.WriteLine($"A data é: {data}");
Console.WriteLine("------------------------------");

//5
Console.WriteLine("5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;\n");
const byte ano = 12;
Console.WriteLine($"A quantidade de meses no ano é de: {ano}");
Console.WriteLine("------------------------------");

//6
Console.WriteLine("6- Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.\n");
double? nota = 7.80;
Console.WriteLine($"A nota é: {nota}");
Console.WriteLine("------------------------------");

//7
Console.WriteLine("7- Quais as diferenças entre os tipos por valor e os tipos por referência ?\n");
Console.WriteLine("O tipo por valor armazena o e armazenado na memória stack(last in first out),");
Console.WriteLine("e o de referência e guardada na memória heap que significa que o que contem na variavel é só referenciada n armazenada direta");
Console.WriteLine("------------------------------");

//8
Console.WriteLine("8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:\n");
Console.WriteLine("(byte) x = 10;");
Console.WriteLine("(double) numero = 7.99;");
Console.WriteLine("(char) letra = 'C';");
Console.WriteLine("(float) temperatura = 27.4f;");
Console.WriteLine("(bool) ativo = false;");
Console.WriteLine("(string) nome = \"Manoel\";");
Console.WriteLine("(decimal) salario = 950.99m;");
Console.WriteLine("(DateTime) hoje = DateTime.Now;");
Console.WriteLine("------------------------------");

//9
Console.WriteLine("9- Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por referência (R) :\n");
Console.WriteLine("(V) int n = 1;");
Console.WriteLine("(R) string titulo = \"A vida\";");
Console.WriteLine("(V) float f = 12.45f;");
Console.WriteLine("(V) double d = 5.45;");
Console.WriteLine("(V) decimal valor = 10.99m;");
Console.WriteLine("(V) char sexo = 'M';");
Console.WriteLine("(R) object o = null;");
Console.WriteLine("------------------------------");

//10
Console.WriteLine("10- O que é um nullable type e qual a sua utilidade ?\n");
Console.WriteLine("O Nullable é um jeito de variaveis que necessitam de valor aceitem o valor null(nulo,\"fiquem vazias\")");
Console.WriteLine("para utilizar ele temos duas mareira");
Console.WriteLine("com o Nullable<tipo> e o tipo?");
Console.WriteLine("exemplo: Nullable<int>, int?");
Console.WriteLine("é utilizado quando o dado é inexistente.");
Console.WriteLine("um exemplo e quando vc precisa guardar um valor num banco de dados é ele necessarimente precisa estar vazio caso n tenha uma resposta");
Console.WriteLine("------------------------------");

//11
Console.WriteLine("11- O que é Camel Case ? Dê um exemplo de sua aplicação.\n");
Console.WriteLine("O CamelCase é um metodo de facilitar a leitura do codigo");
Console.WriteLine("que consiste escrever o nome de variaveis com a primeira letra minuscula e as palavras que a vem logo em seguida colocada com a primeira letra maiuscula");
Console.WriteLine("exemplo: nomeCompleto, salarioProgramador");
Console.WriteLine("------------------------------");

//12
Console.WriteLine("12- O que é Pascal Case ? Dê um exemplo de sua aplicação.\n");
Console.WriteLine("O PascalCase e o jeito de nomear classes e metodos de jeito que quando vc olhar reconheça,");
Console.WriteLine("consiste em colocar a primeira letra maiscula e as palavras que vem a seguida coladas com a primeira letra maiuscila");
Console.WriteLine("exemplo: Pessoa, FilmesEmExebicao, NumerosBinarios");
Console.WriteLine("------------------------------");

//13
Console.WriteLine("13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma)\n");
int x = 77;
int y = 66;
Console.WriteLine($"O valor da Soma de {x} + {y} = {x + y}");
Console.WriteLine("------------------------------");

//14
Console.WriteLine("14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.\n");
Console.WriteLine("Bool = false");
Console.WriteLine("char = \0(null)");
Console.WriteLine("int = 0");
Console.WriteLine("double = 0");
Console.WriteLine("float = 0");
Console.WriteLine("decimal = 0");
Console.WriteLine("string = null");
Console.WriteLine("------------------------------");


//15
Console.WriteLine("15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando a nomenclatura usada:\n");
Console.WriteLine("(F) double 1valor = 12.45;");
Console.WriteLine("(F) string #nome = \"Pedro\"; ");
Console.WriteLine("(V) float _temperatura = 12.45f;");
Console.WriteLine("(F) double int = 5;"); 
Console.WriteLine("(F) decimal renda extra = 91.45m;");
Console.WriteLine("(F) bool status$conta = false;");
Console.WriteLine("(V) string titulo3 = \"Tópico 1\";"); 
Console.WriteLine("(V) float salario_mensal = 1999.55f;");
Console.WriteLine("(V) int percentualValorDesconto = 5;");
Console.WriteLine("(V) const bool MENSALIDADE_EM_DIA = true"); 
Console.WriteLine("------------------------------");
