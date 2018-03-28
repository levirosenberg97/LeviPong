using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public static float paddleLength = 2;

    public void ChangeSize(string input)
    {
        float length = float.Parse(input);
        paddleLength = length;
    }

    public void ChangeAmountToWin(string input)
    {
        int score = int.Parse(input);
        BallScript.pointsToWin = score;
    }



}
