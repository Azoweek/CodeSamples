public class ArmoredUnit : Unit
{
    public int Armor { get; }


    public ArmoredUnit(int maxHealth, int armor) : base(maxHealth)
    {
        Armor = armor;
    }

    public override void TakeDamage(int damage)
    {
        if (Armor < damage)
        {
            Health -= damage - Armor;
        }
    }
}