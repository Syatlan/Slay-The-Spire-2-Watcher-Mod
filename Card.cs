
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
    public Stance StanceEffect { get; set; } = Stance.None;
    public Card(string name, int cost, int damage, int block, CardType type)
    {
        Name = name;
        Cost = cost;
        Damage = damage;
        Block = block;
        Type = type;
    }

    public void Play(Player player)
    {
        if (Damage > 0)
            player.Attack(Damage);

        if (Block > 0)
            player.GainBlock(Block);
            
        if (player.Energy < Cost)
            return;

        player.Energy -= Cost;
    }

    public Card(string name, int cost, int damage, int block, CardType type, Stance stanceEffect = Stance.None)
    {
        Name = name;
        Cost = cost;
        Damage = damage;
        Block = block;
        Type = type;
        StanceEffect = stanceEffect;
    }
}

