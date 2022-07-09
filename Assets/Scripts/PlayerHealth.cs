using PlayerProps;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public HealthBar healthBar;

    void Start()
    {
        Player.CurrentHealth = Player.MaxHealth;
        healthBar.SetMaxHealth(Player.CurrentHealth);
    }

    void Update()
    {
        
        healthBar.SetHealth(Player.CurrentHealth);
        
        if (Player.CurrentHealth <= 0)
        {
            Die();
        }
    }

    public static void TakeDamage(int damage)
    {
        Player.CurrentHealth -= damage;
    }

    void Die()
    {
            Debug.Log("Lmao ur ded");
    }
}
