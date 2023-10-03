namespace projetinho;

public class Inseto : Animal // herança
{
    public override Animal ObterInformacoes() // Método
    {
        var inseto = new Inseto(); // instância
        inseto.Nome = "Barata";
        inseto.Tipo = "Inseto";
        inseto.MediaPeso = "100g";
        inseto.Tamanho = "9 centimetros";

        return inseto;
    }
}
