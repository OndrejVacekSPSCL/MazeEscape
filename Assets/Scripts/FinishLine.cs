using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public playerControl playerControl;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            ToggleFinishPanel();
        }
    }

    [SerializeField] GameObject finishPanel;

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
