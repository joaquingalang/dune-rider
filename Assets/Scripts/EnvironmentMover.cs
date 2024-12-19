using UnityEngine;

public class EnvironmentMover : MonoBehaviour
{
    [SerializeField] GameObject environment;
    float speed = 50;

    EnvironmentMover environmentMover;
    
    void Awake()
    {
        // Enable component's environment mover script
        environmentMover = GetComponent<EnvironmentMover>();
        environmentMover.enabled = true;
    }

    void Update()
    {
        // Move environment game object
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Delete the game object once it reaches an x-position of 95
        if (transform.position.x >= 95) {
            Destroy(gameObject);
            Vector3 spawnLocation = new Vector3(-568.799988f, 4.3097744f, -3.69455743f);
            Instantiate(environment, spawnLocation, Quaternion.identity);
        }
    }
}
