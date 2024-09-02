namespace ConsoleApp1;

public class ClienteService(IClienteRepository clienteRepository) : IClienteService
{
    public Cliente ObterCliente()
    {
        return clienteRepository.ObterCliente();
    }
}