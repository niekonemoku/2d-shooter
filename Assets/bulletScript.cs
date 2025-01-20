using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 5f;  // Time before the bullet destroys itself

    void Start()
    {
        // Destroy the bullet after the specified lifetime
        Destroy(gameObject, lifetime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // If the bullet collides with something, destroy the bullet
        Destroy(gameObject);
    }
}
