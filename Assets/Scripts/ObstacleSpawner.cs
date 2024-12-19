using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject rock01;
    [SerializeField] GameObject rock02;
    [SerializeField] GameObject rock03;
    [SerializeField] GameObject rock04;
    List<GameObject> rocks = new List<GameObject>();

    float cooldownDuration = 0.5f;
    float cooldownTimer = 0f;
    
    void Start()
    {
        // Initialize list of different rocks
        rocks = new List<GameObject> {rock01, rock02, rock03, rock04};
    }

    void SpawnObstacle() {
        // Get random rock prefab
        int randomIndex = Random.Range(0,3);
        GameObject randomRock = rocks[randomIndex];

        // Get random position
        float randomPositionZ = Random.Range(-8, 10);
        Vector3 finalPosition = new Vector3(-450, 0, randomPositionZ);
        Instantiate(randomRock, finalPosition, Quaternion.identity);
    }

    void Update()
    {
        // Spawn two obstacles once cooldown recharges
        if (cooldownTimer <= 0) {
            SpawnObstacle();
            SpawnObstacle();
            cooldownTimer = cooldownDuration;
        }

        // Resets reduce cooldown
        cooldownTimer -= Time.deltaTime;

    }
}
