using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
   public void LevelComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LevelLost()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", 2f);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Hub");
    }
    public void CompleteGame()
    {
        SceneManager.LoadScene("StartingMenu");
    }
}
