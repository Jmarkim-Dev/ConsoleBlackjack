using ConsoleBlackjack;
using Op = ConsoleBlackjack.Operacoes;

const string NomeJogadorA = "Jogador A";
const string NomeJogadorB = "Jogador B";

const string Comprar = "Comprar";
const string Parar = "Parar";

do
{
	IEnumerable<string> baralho = new List<string>();

	List<string> cartasJogadorA = new();
	List<string> cartasJogadorB = new();

	cartasJogadorA.Add(Regras.ComprarCarta(ref baralho));
	cartasJogadorB.Add(Regras.ComprarCarta(ref baralho));

	int acaoJogadorA;
	int acaoJogadorB;
	do
	{
		Console.WriteLine();
		Regras.EscreverPilha(cartasJogadorA, NomeJogadorA);

		Console.WriteLine();
		Regras.EscreverPilha(cartasJogadorB, NomeJogadorB);

		Console.WriteLine();
		acaoJogadorA = Op.LerOpcao($"{NomeJogadorA}, Escolha uma ação:", Comprar, Parar);

		Console.WriteLine();
		acaoJogadorB = Op.LerOpcao($"{NomeJogadorB}, Escolha uma ação:", Comprar, Parar);

		if (acaoJogadorA == 0)
			cartasJogadorA.Add(Regras.ComprarCarta(ref baralho));

		if(acaoJogadorB == 0)
			cartasJogadorB.Add(Regras.ComprarCarta(ref baralho));
	} while (acaoJogadorA == 0 || acaoJogadorB == 0);

	int pontuacaoJogadorA = 0;
	foreach (var carta in cartasJogadorA)
	{
		pontuacaoJogadorA += Regras.ValorCarta(carta);
	}

	int pontuacaoJogadorB = 0;
	foreach (var carta in cartasJogadorB)
	{
		pontuacaoJogadorB += Regras.ValorCarta(carta);
	}

	Console.WriteLine();
	Regras.EscreverPilha(cartasJogadorA, NomeJogadorA);
	Console.WriteLine($"Pontuação total: {pontuacaoJogadorA} pontos");
	
	Console.WriteLine();
	Regras.EscreverPilha(cartasJogadorB, NomeJogadorB);
	Console.WriteLine($"Pontuação total: {pontuacaoJogadorB} pontos");

	Console.WriteLine();
	if (pontuacaoJogadorA > 21 && pontuacaoJogadorB > 21)
		Console.WriteLine("Empate!");
	else if (pontuacaoJogadorA > 21 && pontuacaoJogadorB <= 21)
		Console.WriteLine("Venceddor: " + NomeJogadorB);
	else if (pontuacaoJogadorA <= 21 && pontuacaoJogadorB > 21)
		Console.WriteLine("Venceddor: " + NomeJogadorA);
	else if (pontuacaoJogadorA == pontuacaoJogadorB)
		Console.WriteLine("Empate!!");
	else 
	{ 
		string venceddor = pontuacaoJogadorA > pontuacaoJogadorB ? NomeJogadorA : NomeJogadorB;
		Console.WriteLine("Venceddor: " + venceddor);
	}

} while (Op.LerBool("Outra partida?"));