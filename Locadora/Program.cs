using Locadora;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Modelo do carro");
        string modelo = Console.ReadLine();

        Console.WriteLine("data de saida");
        DateTime datasaida = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("data retorno");
        DateTime dataretorno=DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Valor por hora: ");
        double valorhora = double.Parse(Console.ReadLine());

        Console.WriteLine("valor diario");
        double valordiario = double.Parse(Console.ReadLine());

        Locacao loc = new Locacao(modelo,  datasaida, dataretorno, valorhora, valordiario);

      
        Console.WriteLine(loc);
    }
}