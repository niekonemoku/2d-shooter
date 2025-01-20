using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int health = 1;  // Health of the enemy (can be increased if needed)

    // Method that is called when the enemy is shot
    public void TakeDamage(int damage)
    {
        health -= damage;

        // If health is 0 or less, the enemy dies
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Call the score manager to increase score
        scoreManager.IncreaseScore();

    }
}
