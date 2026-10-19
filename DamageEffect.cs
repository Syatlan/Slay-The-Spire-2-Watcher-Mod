public class DamageEffect : CardEffect
{
    public int Damage { get; set; }

    public DamageEffect(int damage)
    {
        Damage = damage;
    }

    public override void Apply(Player player)
    {
        player.Attack(Damage);
    }
}