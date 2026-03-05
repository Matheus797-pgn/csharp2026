using static System.Console;
int entrada, saida, Turista_saida, Turista_entrada, saida1, saida2;
string sair;
while (true) {
Write("os veiculos estão entrando, saindo ou sair para sair do programa");
sair = ReadLine();
Write("Digite o numero de carros que vai entrar: ");
entrada = int.Parse(ReadLine());
Write("Digite o numero de pessoas que entraram");
Turista_entrada = int.Parse(ReadLine());
    Write($"o total de carros dentro do parque é {entrada} o total de turista dentro do carro é de  {Turista_entrada} ");
    Write("Quanto carros sairam do parque? ");
    saida = int.Parse(ReadLine());
    Write("Quantas pessoas sairam do parque? ");
    Turista_saida = int.Parse(ReadLine());
    saida1 = entrada - saida;
    Write($"faltou sair {saida1} carro do parque ");
    saida2 = Turista_entrada - Turista_saida;
    Write($"faltou sair {saida2} pessoas do parque ");
    if(sair == "sair")
    {

        break;
    }
}






