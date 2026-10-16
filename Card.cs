
 // Available types of cards
public enum CardType
{
    Attack,
    Skill,
    Power
}

public class Card
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public int Damage { get; set; }
    public int Block { get; set; }
    public CardType Type { get; set; }

    public Card(string name, int cost, int damage, int block, CardType type)
    {
        Name = name;
        Cost = cost;
        Damage = damage;
        Block = block;
        Type = type;
    }
}

