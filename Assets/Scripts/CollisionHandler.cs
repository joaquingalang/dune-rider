using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

    [SerializeField] ParticleSystem explosionParticles;
    float score;
    float scoreBuffer;

    void LoadHomeScreen() {
        SceneManager.LoadScene("Home Screen");
    }

    void Start() {
        scoreBuffer = Time.time;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Untagged") {
            Debug.Log("Collision!");
            score = (Time.time - scoreBuffer) * 10;
            ScoreKeeper.playerScore = (int) score;
            if ((int) score > ScoreKeeper.highScore) {
                ScoreKeeper.highScore = (int) score;
            }
            explosionParticles.Play();
            Invoke("LoadHomeScreen", 0.15f);
        }
    }
}
