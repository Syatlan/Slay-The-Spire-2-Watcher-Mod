//string characterName = "Watcher";
Player player = new Player();

//Name,Cost,Damage,Block,Type
Card strike = new Card("Strike", 1, 6, 0, CardType.Attack);
Card defend = new Card("Defend", 1, 0, 5, CardType.Skill);
Card eruption = new Card("Eruption", 2, 9, 0, CardType.Attack);
Card vigilance = new Card("Vigilance", 2, 0, 8, CardType.Skill);

List<Card> deck = new List<Card>();

//Starting deck: 4 Strikes, 4 Defends, 1 Eruption, 1 Vigilance
for (int i = 0; i < 4; i++)
{
    deck.Add(strike);
    deck.Add(defend);
}

deck.Add(eruption);
deck.Add(vigilance);    


player.ChangeStance(Stance.Wrath);

Console.WriteLine(player.Attack(6));
Console.WriteLine(player.ReceiveDamage(5));
public class Player
{
    public int Energy { get; set; } = 3;
    public int DealDamage { get; set; } = 0;
    public int TakeDamage { get; set; } = 0;
    public int HP { get; set; } = 70;
    public int Block { get; set; } = 0;
    
    public Stance CurrentStance { get; set; } = Stance.None;
    private StanceManager stanceManager = new StanceManager();

    public void ChangeStance(Stance newStance)
    {
        Energy = stanceManager.GainEnergy(CurrentStance, newStance, Energy);

        CurrentStance = newStance;
    }

    public int Attack(int baseDamage)
    {
        return stanceManager.DealDamage(CurrentStance, baseDamage);
    }

    public int ReceiveDamage(int baseDamage)
    {
        return stanceManager.TakeDamage(CurrentStance, baseDamage);
    }

    public void GainBlock(int amount)
    {
        Block += amount;
    }

    public void GainEnergy(int amount)
    {
        Energy += amount;
    }
}





