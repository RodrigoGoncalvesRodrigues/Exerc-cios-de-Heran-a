using System.Reflection.Metadata;

public class Moto : Veiculo
{
    private bool temBagageiro;

    public void darGrau()
    {
        Console.WriteLine("Radandandan  PÁ,PÁ");
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca:{Marca},Modelo do veículo:{Modelo}, Ano do veículo:{Ano}, Quantos bagageiros:{temBagageiro}");
    }
    public Moto(string Marca, string Modelo, int Ano, bool temBagageiro):base(Marca, Modelo, Ano)
    {
        temBagageiro = temBagageiro;
    }
}