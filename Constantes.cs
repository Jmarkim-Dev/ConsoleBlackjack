namespace ConsoleBlackjack;
public static class Constantes
{
	public static string[] Naipes = { "Copas", "Ouros", "Espada", "Paus" };
	public static string[] Valores = { "#A", "02", "03", "04",  "05" , "06", "07", "08", "09", "10", "#J", "#Q", "#K" };

	public static IEnumerable<string> BaralhoPadrão => Naipes.Join(Valores, x => true, x => true, ( naipe, valor ) => $"{valor} - {naipe}");
}
