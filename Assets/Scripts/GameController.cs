using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class GameController : MonoBehaviour
{
    public playerControl playerControl;
    Vector2 startPos;
    private void Start() {
        startPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Obstacle")) {
            Die();
        }
    }

    public void Die() {
        LevelManager.instance.GameOver();
        playerControl.ChangeMovementSpeed(0);
    }

    public void Respawn() {
        transform.position = startPos;
    }

    public void doExitGame() {
        Application.Quit();
    }
}
