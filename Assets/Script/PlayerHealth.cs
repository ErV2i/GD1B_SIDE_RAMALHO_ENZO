using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else if (health == 1)
        {
            Destroy(gameObject1);
        }
        else if (health == 2)
        {
            Destroy(gameObject2);
        }
         else if (health == 0)
        {
            Destroy(gameObject3);
            Destroy(gameObject2);
            Destroy(gameObject1);
        }
    }
}
