using System;

namespace projetinho
{
    public class Mamifero : Animal
    {

        public override Animal ObterInformacoes()
        {
            var mamifero = new Mamifero();
            mamifero.Nome = "Elefante";
            mamifero.Tipo = "Mamifero";
            mamifero.MediaPeso = "10000kg";
            mamifero.Tamanho = "8 metros";

            return mamifero;
        }

    }
}