using static System.Console;
double Precounitario, Quantidade, Dinheirorecebido, troco;
Console.WriteLine("preco do produto é");
Precounitario = double.Parse(ReadLine());
Console.WriteLine("a quantidade é");
Quantidade = double.Parse(ReadLine());
Console.WriteLine("O dinheiro recebido é");
Dinheirorecebido = double.Parse(ReadLine());
//processamento de dados
troco = Dinheirorecebido-(Precounitario*Quantidade);
// saida de dados
Console.WriteLine($"o seu troco é {troco}");