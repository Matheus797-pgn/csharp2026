double precounitario, quantidade, dinheirorecebido, troco;
Console.WriteLine("preco dos produtos é");
precounitario = double.Parse(ReadLine());
Console.WriteLine("a quantidade é");
quantidade = double.Parse(ReadLine());
Console.WriteLine("O dinheiro recebido é");
dinheirorecebido = double.Parse(ReadLine());
//processamento de dados
troco = dinheirorecebido-(precounitario*quantidade);
// saida de dados
Console.WriteLine($"o seu troco é {troco}");