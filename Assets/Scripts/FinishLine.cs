using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public playerControl playerControl;
    [SerializeField] GameObject finishPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            ToggleFinishPanel();
        }
    }

    public void ToggleFinishPanel()
    {
        finishPanel.SetActive(!finishPanel.activeSelf);
        playerControl.ChangeMovementSpeed(0);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
