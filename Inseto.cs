using System;

namespace projetinho
{
    public class Inseto : Animal
    {
        public override Animal ObterInformacoes()
        {
            var inseto = new Inseto();
            inseto.Nome = "Barata";
            inseto.Tipo = "Inseto";
            inseto.MediaPeso = "100g";
            inseto.Tamanho = "9 centimetros";

            return inseto;
        }
    }
}