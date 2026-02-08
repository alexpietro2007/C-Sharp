Console.WriteLine("## Nullable Types ##\n");

//o valor é deinido e aceito pela variavel
int valor = 100;

//se o valor for null da um erro
//int valor = null;

//Nullable types permitem que uma variável de tipo valor possa ser null
Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

//outra forma de declarar um nullable type
int? i2 = null;
double? d2 = null;
bool? b2 = null;

/*
Os Nullable types são diferentes dos tipos que foram declarados sem o Nullable
int? i = null;
int i2 = i; da um erro de compilação porque i é um Nullable e i2 é um tipo valor normal
*/

/*
Para acessar o valor de um Nullable type,
é necessário usar a propriedade Value ou o operador de coalescência nula (??)
para fornecer um valor padrão caso seja null*/
int? a = null;
int b3 = a ?? 0; //se i3 for null, b recebe 0


/*
Esse cuidado tem que ter tbm nas expressões
int? x = 4;
int y = 3;
int z = x * y; da um erro de compilação porque x é um Nullable e y é um tipo valor normal,
então é necessário usar o operador de coalescência nula para fornecer um valor padrão caso seja null
*/

int? x = 4;
int? y = 3;
int? z = x * y;

/*
O Nullable possui a propriedade HasValue para verificar se o valor é null ou não, e a propriedade Value para acessar o valor caso não seja null
int? x = null;
console.WriteLine(x.HasValue); //false
*/


Console.WriteLine("------------------------------");
Console.WriteLine("Valor Aceito:\n");
Console.WriteLine($"Valor: {valor}");
Console.WriteLine("------------------------------");
Console.WriteLine("Valores que n aceitam null com Nullable:\n");
Console.WriteLine($"Nullable<int> i: {i}");
Console.WriteLine($"Nullable<double> d: {d}");
Console.WriteLine($"Nullable<bool> b: {b}\n");
Console.WriteLine("Outro jeito de declarar o Nullable é o tipo com o sinal de ?\n");
Console.WriteLine($"int? i2: {i2}");
Console.WriteLine($"double? d2: {d2}");
Console.WriteLine($"bool? b2: {b2}");
Console.WriteLine("------------------------------");
Console.WriteLine("Variaveis normais podem receber valores null se usar o ?? (coalescência nula) \n");
Console.WriteLine($"int? a: Null");
Console.WriteLine($"int b3 = a ?? 0: {b3}");
a = 1;
Console.WriteLine($"int? a = 1, int b3 = a ?? 0: {b3 = a ?? 0}");
Console.WriteLine("------------------------------");
Console.WriteLine("Para que consiga fazer Expressões todos tem que ser Nullable:\n");
Console.WriteLine($"int? x: {x}");
Console.WriteLine($"int? y: {y}");
Console.WriteLine($"int? z = x * y: {z}");
Console.WriteLine("------------------------------");
Console.WriteLine("O Nullable tem uma propriedade que Verifica se um valor é nulo ou não HasValue:\n");
Console.WriteLine("Aqui x possui um Valor:");
if (x.HasValue){
    Console.WriteLine($"x: {x.Value}\n");
}else{
    Console.WriteLine("x: null\n");
}
Console.WriteLine("Aqui x não possui valor:");
x = null;
if (x.HasValue){
    Console.WriteLine($"x: {x.Value}");
}else{
    Console.WriteLine("x: null");
}
Console.WriteLine("------------------------------");