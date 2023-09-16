using System;

namespace projetinho
{
    class Program
    {
        static void Main(string[] args)
        {
            var mamifero = new Mamifero();
            var inseto = new Inseto();

            var resultadoMamifero = mamifero.ObterInformacoes();
            var resultadoInseto = inseto.ObterInformacoes();

            Console.WriteLine($"Oi, me chamo {resultadoMamifero.Nome}, sou um {resultadoMamifero.Tipo} e eu peso {resultadoMamifero.MediaPeso}, com o tamanho de {resultadoMamifero.Tamanho}.");
            Console.WriteLine($"Oi, me chamo {resultadoInseto.Nome}, sou um {resultadoInseto.Tipo} e eu peso {resultadoInseto.MediaPeso}, com o tamanho de {resultadoInseto.Tamanho}.");
        }
    }
}
