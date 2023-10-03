
namespace projetinho;

public abstract class Animal
{
        // propriedades
    public string Nome { get; set; } // encapsulamento da propriedade
    public string Tipo { get; set; } // encapsulamento da propriedade
    public string Tamanho { get; set; } // encapsulamento da propriedade
    public string MediaPeso { get; set; } // encapsulamento da propriedade
    public abstract Animal ObterInformacoes(); // método
}

