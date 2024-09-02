namespace ConsoleApp1;

public class Cliente
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public override string ToString()
    { 
        return $"{Name} {LastName}";
    }
}