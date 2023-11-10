using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScreenManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOverUI;

    void Update()
    {
        
    }
    public void gameOver(){
        GameOverUI.SetActive(true);
    }
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void mainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void quit(){
        Application.Quit();
    }
}
