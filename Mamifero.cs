namespace projetinho;

public class Mamifero : Animal // herança
{

    public override Animal ObterInformacoes() // Método
    {
        var mamifero = new Mamifero(); // instância
        mamifero.Nome = "Elefante";
        mamifero.Tipo = "Mamifero";
        mamifero.MediaPeso = "10000kg";
        mamifero.Tamanho = "8 metros";

        return mamifero;
    }

}
