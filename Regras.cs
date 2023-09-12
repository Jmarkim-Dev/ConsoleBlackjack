namespace ConsoleBlackjack;
public static class Regras
{
	public static IEnumerable<string> Baralho => Embaralha(Constantes.BaralhoPadrão);

	public static string ComprarCarta(ref IEnumerable<string> baralho)
	{
		if (baralho is null || !baralho.Any())
			baralho = Baralho;

		var carta = baralho.First();

		baralho = baralho.Take(1..);

		return carta;
	}

	public static void EscreverPilha(IEnumerable<string> pilha, string jogador)
	{
		Console.WriteLine($"Cartas de {jogador}");
		foreach (var item in pilha)
		{
			Console.WriteLine($"{item} ({ValorCarta(item)})");
		}
	}

	public static int ValorCarta(string valor)
	{
		var digitos = valor.Substring(0, 2);

		switch (digitos)
		{
			case "#A":
				return 1;

			case "#J":
			case "#Q":
			case "#K":
				return 10;

			default:
				return int.Parse(digitos);
		}
	}

	private static IEnumerable<T> Embaralha<T>(IEnumerable<T> lista)
	{
		List<T> embaralhado = new();

		List<T> items = new();

		items.AddRange(lista);

		while (items.Count > 0)
		{
			int pos = Random.Shared.Next(0, items.Count);
			embaralhado.Add(items[pos]);
			items.RemoveAt(pos);
		}

		return embaralhado;
	}
}
