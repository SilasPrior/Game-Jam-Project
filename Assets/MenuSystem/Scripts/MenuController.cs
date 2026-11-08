using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] string playscene = "SampleScene";
    [SerializeField] string mainMenuScene = "StartScene";

    public void StartGame()
    {
        StartCoroutine(SceneDelay());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private IEnumerator SceneDelay()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(playscene);
    }
}
