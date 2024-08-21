// int numero = 10;
// double pi = 3.1415;
// char letra = 'A'; ///pode ser somente 'a' letra ou o codigo da letra
// bool isTrue = true; ///só recebe true ou false
// string mensagem = "olá mundo!";

// int X, y;
// Console.WriteLine("Digitar o valor de x:");
// X = Convert.ToInt32 (Console.ReadLine());
// //formatação de string usando concatenação
// Console.WriteLine("O usuario digitou:" + X + "parabens");
// //interpolação de string
// Console.WriteLine($"O usuario digitou {X} parabens");
// //usando placeholders
// Console.WriteLine("o usuario digitou {0} parabens", X);


int x, y;
double divisao;
double soma;
double menos;
double multiplicacao;

Console.WriteLine("Digite o valor de X:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor de Y:");
y = Convert.ToInt32(Console.ReadLine());

divisao = (double) x / y;
soma = (double) x + y;
menos = (double) x - y;
multiplicacao = (double) x * y;



Console.WriteLine($"O valor da divisao entre {x} e {y} é igual a: {divisao}");
Console.WriteLine($"O valor da soma entre {x} e {y} é igual a: {soma}");
Console.WriteLine($"O valor da subitração entre {x} e {y} é igual a: {menos}");
Console.WriteLine($"O valor da multiplicação entre {x} e {y} é igual a: {multiplicacao}");