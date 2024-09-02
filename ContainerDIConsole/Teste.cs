namespace ConsoleApp1;

public class Teste
{
    private readonly IClienteService _clienteService;
    public Teste()
    {
        _clienteService = ServiceLocator.GetService<IClienteService>();
    }
    public void Run()
    {
        var cliente = _clienteService.ObterCliente();
        Console.WriteLine(cliente);
    }
}