using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{

    float speed = 50;

    void Update()
    {
        // Move the obstacle every frame
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Delete the game object once it reaches a certain position
        if (transform.position.x >= 18) {
            Destroy(gameObject);
        }
    }
}
