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

	Console.WriteLine();
	Regras.EscreverPilha(cartasJogador, "Jogador");
	Console.WriteLine();

} while (Op.LerBool("Outra partida?"));