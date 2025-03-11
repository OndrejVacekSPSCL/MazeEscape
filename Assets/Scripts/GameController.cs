using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class GameController : MonoBehaviour
{
    public playerControl playerControl;
    [SerializeField] GameObject deathPanel;

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
        playerControl.ChangeMovementSpeed(0);
        ToggleDeathPanel();
    }

    public void Respawn() {
        transform.position = startPos;
    }

    public void doExitGame() {
        Application.Quit();
    }

    public void ToggleDeathPanel()
    {
        deathPanel.SetActive(!deathPanel.activeSelf);
    }
}
