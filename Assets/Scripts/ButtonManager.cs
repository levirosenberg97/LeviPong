using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    

    public void quitGame()
    {
        Application.Quit();
    }

    public void LoadLevel(string wool)
    {
        SceneManager.LoadScene(wool);

        BallScript.player1Score = 0;

        BallScript.player2Score = 0;
    }

}
