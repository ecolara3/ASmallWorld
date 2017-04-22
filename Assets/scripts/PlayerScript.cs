using UnityEngine;

/// <summary>
/// Player controller and behavior
/// </summary>
public class PlayerScript : MonoBehaviour
{
    /// <summary>
    /// 1 - The speed of the ship
    /// </summary>
    public Vector2 speed = new Vector2(50, 50);

    // 2 - Store the movement and the component
    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    void Update()
    {
        // 3 - Retrieve axis information
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // 4 - Movement per direction
        movement = new Vector2(
          speed.x * inputX,
          speed.y * inputY);

    }

    void FixedUpdate()
    {
        // 5 - Get the component and store the reference
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        // 6 - Move the game object
        rigidbodyComponent.velocity = movement;
    }
}