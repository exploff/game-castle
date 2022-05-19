using UnityEngine;
public class HealthPlayer : MonoBehaviour
{

    public int maxHealth = 18;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetHealth(currentHealth);
    }

    void Update()
    {
        
    }
}
