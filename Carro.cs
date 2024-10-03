public class Carro : Veiculo
{
    private int numeroDePortas;

    public void  abrirPortaMalas()
    {
        Console.WriteLine("O porta malas está aberto");
    }

    public void ExibirInformacoes()
    {
            Console.WriteLine($"Marca:{Marca}, Modelo de carro {Modelo}, número de portas {numeroDePortas}");

    }
    public Carro (string Marca, string Modelo, int Ano, int numeroDePortas) : base(Marca,Modelo,Ano)
    {
        this.numeroDePortas = numeroDePortas;
    }
    
    
}