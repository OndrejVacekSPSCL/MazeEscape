using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
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
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
