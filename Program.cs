using ConsoleBlackjack;
using Op = ConsoleBlackjack.Operacoes;

const string Comprar = "Comprar";
const string Parar = "Parar";

do
{
	IEnumerable<string> baralho = new List<string>();

	List<string> cartasJogador = new();
	List<string> cartasIA = new();

	int acaoJogador;
	do
	{
		Console.WriteLine();
		cartasJogador.Add(Regras.ComprarCarta(ref baralho));

		Regras.EscreverPilha(cartasJogador, "Jogador");

		acaoJogador = Op.LerOpcao("Escolha uma ação:", Comprar, Parar);
	} while (acaoJogador == 0);

	int pontuacaoJogador = 0;
	foreach (var carta in cartasJogador)
	{
		pontuacaoJogador += Regras.ValorCarta(carta);
	}

	Console.WriteLine();
	Regras.EscreverPilha(cartasJogador, "Jogador");
	Console.WriteLine($"Pontuação total: {pontuacaoJogador} pontos");
	Console.WriteLine();

	if (pontuacaoJogador <= 21)
	{
		Console.WriteLine("Você venceu!");
	}
	else
	{
		Console.WriteLine("Você perdeu, mais sorte da próxima vez.");
	}

} while (Op.LerBool("Outra partida?"));