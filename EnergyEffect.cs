public class EnergyEffect : CardEffect
{
    public int Energy { get; set; }

    public EnergyEffect(int energy)
    {
        Energy = energy;
    }

    public override void Apply(Player player)
    {
        player.GainEnergy(Energy);
    }
}