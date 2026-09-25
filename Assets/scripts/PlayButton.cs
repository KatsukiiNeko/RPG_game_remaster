using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}

