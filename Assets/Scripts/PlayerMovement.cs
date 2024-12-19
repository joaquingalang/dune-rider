using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] float speed = 20;
    [SerializeField] InputAction movement;
    [SerializeField] ParticleSystem boosterParticles;
    [SerializeField] ParticleSystem dustParticles;
    Rigidbody rb;


    void OnEnable() {
        // Enable the movement input system
        movement.Enable();

        // Play booster and dust particles
        boosterParticles.Play();
        dustParticles.Play();
    }    

    void onDisable() {
        // Disable the movement input system
        movement.Disable();
    }

    void Start() {
        // Retrieve the rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Read movement input value
        float movementInput = movement.ReadValue<float>();

        // Move the player based on user input
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        if (movementInput > 0) {
            rb.AddForce(Vector3.forward * speed * Time.fixedDeltaTime);
        } else if (movementInput < 0) {
            rb.AddForce(Vector3.back * speed * Time.fixedDeltaTime);
        }

    }
}
