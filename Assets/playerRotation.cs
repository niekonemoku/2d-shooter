using UnityEngine;

public class RotateTowardsMouse : MonoBehaviour
{
    public float angle=0;

    void Update()
    {
        // Get the mouse position in world space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculate the direction from the object to the mouse
        Vector3 direction = mousePosition - transform.position;

        // Set the z-component of the direction to zero because we're in 2D
        direction.z = 0;

        // Calculate the angle to rotate towards
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg -90;

        // Rotate the object to face the mouse position
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
