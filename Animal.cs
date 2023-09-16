using System;

namespace projetinho
{
    public abstract class Animal
    {
        // atributos
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Tamanho { get; set; }
        public string MediaPeso { get; set; }

        public abstract Animal ObterInformacoes();
    }
}
