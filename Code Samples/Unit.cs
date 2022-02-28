using System;


public class Unit
{
    public event Action OnDestroy;

    public int MaxHealth { get; }
    public int Health
    {
        get => _health;
        protected set
        {
            if (value <= 0)
            {
                OnDestroy?.Invoke();
                _health = 0;
            }
            else
            {
                _health = value;
            }
        }
    }

    private int _health;


    public Unit(int maxHealth)
    {
        Health = maxHealth;
        MaxHealth = maxHealth;
    }

    public virtual void TakeDamage(int damage)
    {
        // Default logic
        Health -= damage;
    }
}