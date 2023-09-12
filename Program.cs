using ConsoleBlackjack;
using Op = ConsoleBlackjack.Operacoes;

// Loop principal

const string Comprar = "Comprar";
const string Parar = "Parar";

List<string> cartasJogador = new();
List<string> cartasIA = new();

do
{
	IEnumerable<string> baralho = new List<string>();

	int acaoJogador;
	do
	{
		cartasJogador.Add(Regras.ComprarCarta(ref baralho));

		Regras.EscreverPilha(cartasJogador, "Jogador");

		acaoJogador = Op.LerOpcao("Escolha uma ação:", Comprar, Parar);
	} while (acaoJogador == 0);

	Regras.EscreverPilha(cartasJogador, "Jogador");

} while (Op.LerBool("Outra partida?"));