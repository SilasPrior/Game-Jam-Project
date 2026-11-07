using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] string playscene = "SampleScene";
    [SerializeField] string mainMenuScene = "StartScene";

    public void StartGame()
    {
        SceneManager.LoadScene(playscene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
