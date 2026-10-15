string characterName = "Watcher";
int health = 70;
int energy = 3;

Card strike = new Card("Strike", 6);
Card defend = new Card("Defend", 5);

Console.WriteLine($"Character: {characterName}");
Console.WriteLine($"Health: {health}");
Console.WriteLine($"Energy: {energy}");
Console.WriteLine($"Card: {strike.Name}");
Console.WriteLine($"Damage: {strike.Damage}");
Console.WriteLine($"Card: {defend.Name}");
Console.WriteLine($"Block: {defend.Damage}");


public class Card
{
    public string Name { get; set; }
    public int Damage { get; set; }

    public Card(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }
}
