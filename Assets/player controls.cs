using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the player moves

    private Vector2 movementInput;

    private void Update()
    {
        // Get input from the WASD keys or arrow keys
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");

        // Normalize the movement vector to ensure consistent speed in all directions
        if (movementInput.magnitude > 1)
        {
            movementInput.Normalize();
        }

        // Move the player character
        transform.Translate(movementInput * moveSpeed * Time.deltaTime);
    }
}
