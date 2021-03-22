using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    bool IsPaused = false;
    public GameObject pauseMenuUI;
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quiting...");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Hub");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("StartingMenu");
    }
    public void OptionButton()
    {
        SceneManager.LoadScene("OptionMenu");
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        IsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        IsPaused = true;
    }
}
