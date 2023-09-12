namespace ConsoleBlackjack;
public static class Regras
{
	public static IEnumerable<string> Baralho => Embaralha(Constantes.BaralhoPadrão);

	public static string ComprarCarta(ref IEnumerable<string> baralho )
	{
		if (baralho is null || !baralho.Any())
			baralho = Baralho;

		var carta = baralho.First();

		baralho = baralho.Take(1..);

		return carta;
	}

	public static void EscreverPilha ( IEnumerable<string> pilha, string jogador)
	{
		Console.WriteLine($"Cartas de {jogador}");
		foreach ( var item in pilha )
		{
			Console.WriteLine (item);
		}
	}

	public static int ValorCarta (string valor )
	{
		return 0;
	}

	private static IEnumerable<T> Embaralha<T>(IEnumerable<T> lista )
	{
		List<T> embaralhado = new();

		List<T> items = new();

		items.AddRange( lista );

		while ( items.Count > 0 )
		{
			int pos = Random.Shared.Next(0, items.Count);
			embaralhado.Add(items[pos]);
			items.RemoveAt(pos);
		}

		return embaralhado;
	}
}
