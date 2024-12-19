using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] InputAction rotation;


    void OnEnable() {
        // Enable rotation input
        rotation.Enable();
    }    

    void onDisable() {
        // Disable rotation input
        rotation.Disable();
    }

    void Update()
    {
        // Read rotation input
        float rotationInput = rotation.ReadValue<float>();
        float angle = 0f;

        // Rotate game object depending on user input
        if (rotationInput > 0) {
            angle = 15f;
        } else if (rotationInput < 0) {
            angle = -15f;
        }

        Vector3 temp = transform.rotation.eulerAngles;
        temp.x = angle;
        transform.rotation = Quaternion.Euler(temp);
    }
}
