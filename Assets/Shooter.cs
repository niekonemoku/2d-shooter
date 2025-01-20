using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;  // Reference to the bullet prefab
    public Transform gunTransform;   // Reference to the gun transform (where bullets spawn)
    public float bulletSpeed = 10f;  // Bullet speed
    public float fireRate = 0.5f;   // Fire rate (time between shots)

    private float nextFireTime = 0f;

    public RotateTowardsMouse code;

    void Update()
    {
        // Check if the fire button is pressed and if enough time has passed since the last shot
        if (Input.GetMouseButtonDown(0) && Time.time >= nextFireTime)
        {
            ShootBullet();
            nextFireTime = Time.time + 1f / fireRate;  // Set the next time the player can shoot
        }
    }

    void ShootBullet()
    {
        // Create a bullet at the gun's position
        GameObject bullet = Instantiate(bulletPrefab, gunTransform.position, Quaternion.identity);

        // Get the direction from the gun to the mouse pointer
        //Vector2 direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition)-gunTransform.position);
        //direction.Normalize();
        //Vector2 direction = new Vector2(Mathf.Cos(gunTransform.eulerAngles.z * Mathf.Deg2Rad),
          //                              Mathf.Sin(gunTransform.eulerAngles.z * Mathf.Deg2Rad));

        // Normalize the direction to ensure it's a unit vector (magnitude of 1)
        //direction.Normalize();

        // Add velocity to the bullet in the direction of the mouse
        //float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg-90;
        float angle = code.angle;

        bullet.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        bullet.transform.localScale = new Vector3(0.15f, 0.15f, 1);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = bullet.transform.up * bulletSpeed;
    }
}
