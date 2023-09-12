namespace ConsoleBlackjack;
public static class Operacoes
{
	public static int LerInt(string instrucao )
	{
		int resultado;
		string entrada;
		bool valido;

		do
		{
			Console.WriteLine(instrucao);
			entrada = Console.ReadLine() ?? string.Empty;

			valido = int.TryParse(entrada, out resultado);

			if (!valido)
				Console.WriteLine("Valor inválido");

		} while ( !valido );
		
		return resultado;
	}

	public static bool LerBool(string instrucao )
	{
		Console.WriteLine($"{instrucao} [S/N]");
		string entrada = Console.ReadLine() ?? string.Empty;
		
		return entrada.First() switch
		{
			'S' => true,
			's' => true,
			'Y' => true,
			'y' => true,
			'V' => true,
			'v' => true,
			_ => false
		};
	}

	public static int LerOpcao(string instrucao, params string[] opcoes )
	{
		Console.WriteLine(instrucao);

		int chave = 0;
		foreach ( string opt in opcoes ) 
		{
			Console.WriteLine($"\t{chave++} - {opt}");
		}

		int escolha;
		bool valido;

		do
		{
			escolha = LerInt(string.Empty);
			valido = escolha >= 0 && escolha < chave;

			if (!valido)
				Console.WriteLine("Opção inválida");

		} while ( !valido );

		return escolha;
	}
}
