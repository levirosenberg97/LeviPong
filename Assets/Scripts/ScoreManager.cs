using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text player1;
    public Text player2;

    public Text winText1;
    public Text winText2;

    public GameObject gameScreen;
    public GameObject winScreen;

    private void Update()
    {
        if (BallScript.player1Score == BallScript.pointsToWin || BallScript.player2Score == BallScript.pointsToWin)
        {
            gameScreen.SetActive(false);

            winScreen.SetActive(true);
        }

        player1.text = BallScript.player1Score.ToString();
        player2.text = BallScript.player2Score.ToString();


        winText1.text = BallScript.player1Score.ToString();
        winText2.text = BallScript.player2Score.ToString();
    }


}
