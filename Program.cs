// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

ConfigurationServices.RegisterServices();

var teste = new Teste();
teste.Run();

//var service = ServiceLocator.GetService<IClienteService>();
//var cliente = service.ObterCliente();
//Console.WriteLine(cliente);