namespace projetinho;
class Program
{
    static void Main(string[] args)
    {
        var mamifero = new Mamifero();
        var inseto = new Inseto();

        var resultadoMamifero = mamifero.ObterInformacoes(); // variável que chama o método
        var resultadoInseto = inseto.ObterInformacoes(); // variável que chama o método

        Console.WriteLine($"Oi, me chamo {resultadoMamifero.Nome}, sou um {resultadoMamifero.Tipo} e eu peso {resultadoMamifero.MediaPeso}, com o tamanho de {resultadoMamifero.Tamanho}.");
        Console.WriteLine($"Oi, me chamo {resultadoInseto.Nome}, sou um {resultadoInseto.Tipo} e eu peso {resultadoInseto.MediaPeso}, com o tamanho de {resultadoInseto.Tamanho}.");
    }
};