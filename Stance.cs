public enum Stance
{
    None,
    Wrath,
    Calm,
    Divinity
}

public class StanceManager
{
    public int DealDamage(Stance stance, int baseDamage)
    {

        if (stance == Stance.Wrath)
            return baseDamage * 2;

        if (stance == Stance.Divinity)
            return baseDamage * 3;

        return baseDamage;

    }

    public int TakeDamage(Stance stance, int dealtDamage)
    {
        if (stance == Stance.Wrath)
            return dealtDamage * 2;

        return dealtDamage;
    }

    public int GainEnergy(Stance currentStance, Stance newStance, int energy)
    {
        if (currentStance == Stance.Calm && newStance != Stance.Calm)
            energy += 2;


        if (currentStance != Stance.Divinity && newStance == Stance.Divinity)
            energy += 3;
        
        return energy;
    }   
}