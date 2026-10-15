
 // Available types of cards
public enum CardType
{
    Attack,
    Skill,
    Power
}

// Represents a card in the game
public class Card
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public int Value { get; set; }
    public CardType Type { get; set; }

    public Card(string name, int cost, int value, CardType type)
    {
        Name = name;
        Cost = cost;
        Value = value;
        Type = type;
    }
}
