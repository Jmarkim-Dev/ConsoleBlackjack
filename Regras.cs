namespace ConsoleBlackjack;
public static class Regras
{
	public static IEnumerable<string> Baralho => Embaralha(Constantes.BaralhoPadrão);

	private static IEnumerable<T> Embaralha<T>(IEnumerable<T> lista )
	{
		List<T> embaralhado = new();

		List<T> items = new();

		items.AddRange( lista );

		while ( items.Count > 0 )
		{
			int pos = Random.Shared.Next(0, items.Count);
			embaralhado.Add(items[pos]);
		}

		return embaralhado;
	}

}
