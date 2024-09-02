namespace ConsoleApp1;

public class ClienteRepository : IClienteRepository
{
    public Cliente ObterCliente()
    {
        return new Cliente
        {
            Name = "João",
            LastName = "Silva"
        };
    }
}