using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public ScoreScript ScoreScript;


    public void PlayGame()
    {
        Debug.Log("Pressed");
        SceneManager.LoadScene(1);
        ScoreScript.scoreValue = 0;
    }

    public void Menues()
    {
        Debug.Log("Pressed");
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}