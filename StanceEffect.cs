public class StanceEffect : CardEffect
{
    public Stance Stance { get; set; }

    public StanceEffect(Stance stance)
    {
        Stance = stance;
    }

    public override void Apply(Player player)
    {
        player.ChangeStance(Stance);
    }
}