using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField]
    int health = 10;
    [SerializeField]
    int maxHealth = 10;

    public void Damage(int damage)
    {
        health -= damage;
        if (health<0) health = 0;
    }

    public void Heal(int heal)
    {
        health += heal;
        if (health>maxHealth) health = maxHealth;
    }

    public void SetHealth(int newHealth)
    {
        health = newHealth;
        if (health < 0) health = 0;
        else if (health > maxHealth) health = maxHealth;
    }

    public int GetHealth() { return health; }
    public int GetMaxHealth() { return maxHealth; }
}
