using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public playerControl playerControl;
    [SerializeField] GameObject inGameMenu;
    [SerializeField] GameObject MenuButton;

    public void ToggleMenuPanel()
    {
        inGameMenu.SetActive(!inGameMenu.activeSelf);
        playerControl.ChangeMovementSpeed(0);
        MenuButton.SetActive(!MenuButton.activeSelf);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
