using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void mozillahub()
    {
        Application.OpenURL("https://hubs.mozilla.com/link/Mbtbtw3");
    }

    public void back()
    {
        SceneManager.LoadScene("UI_Scene");
    }
}
