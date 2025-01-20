using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyFollowPlayer : MonoBehaviour
{
    public Transform player1;  // Reference to the player's position
    public float moveSpeed = 2f;  // Movement speed of the enemy

    void Start() {
        player1 = GameObject.Find("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        if (player1 != null)
        {
            // Calculate direction from enemy to player
            Vector3 direction = player1.position - transform.position;
            direction.z = 0f; // Ensuring we are moving only in 2D (ignores any Z-axis movement)

            // Normalize the direction to ensure consistent movement speed
            direction.Normalize();

            // Move the enemy towards the player
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the enemy collides with a bullet
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Destroy the enemy object when hit by a bullet
            Destroy(gameObject);
        }

        // Check if the enemy collides with the player
        else if (collision.gameObject.CompareTag("Player"))
        {
            // Print "Dead" to the console when the enemy hits the player
            SceneManager.LoadScene("Menu");
        }
    }
}

