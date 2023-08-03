using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{

    public void CloseGame()
    {
        Application.Quit();
    }

    public void ControlsScene()
    {
        SceneManager.LoadScene("Controls");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Setesh Environment (Smol Edition)");
    }

}
