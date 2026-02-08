Console.WriteLine("Definindo Identificadores:\n");

//Indentificadores Validos
string nome;
string nomeCompleto;
byte idade;
int _valor;
byte idade1;

//Indentificadores Invalidos
//int 5idade;
//int $valor;
//int valor#total;
//string nome Completo;

/*
Para nomes de variaveis, eu uso camelCase, ou seja,
a primeira letra da primeira palavra é minuscula e a primeira letra de cada palavra subsequente é maiuscula.
Exemplo: nomeCompleto, idadeUsuario, valorTotal.
*/
string descontoTotal;
string desconto_Total;

/*
Para constantes, eu uso letras maiusculas e separo as palavras com underline.
Exemplo: PI, TAXA_DE_JUROS, VALOR_MAXIMO.
*/
const double PI = 3.14159;
const string PREFIXO = "11";
const string PREFIXO_SP = "11";


/*
Para nome de classes e métodos, eu uso PascalCase, ou seja, a primeira letra de cada palavra é maiuscula.
Exemplo: MinhaClasse, CalcularDesconto, ObterValorTotal.
*/
class ImprimirTexto{
    public void ImprimeNome(){
        Console.WriteLine("Alex\n");
    }
}
