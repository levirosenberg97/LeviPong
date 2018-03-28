using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControls : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public float speed;

    private void Start()
    {
        if (InputManager.paddleLength == 0f)
        {
            InputManager.paddleLength = 2f;
        }
        gameObject.transform.localScale = new Vector3(0.423065f, InputManager.paddleLength, 1f);
    }

    // Update is called once per frame
    void Update ()
    {
        Mathf.Clamp(transform.position.y, -2.900981f, 4.880981f);
		if (Input.GetKey(up))
        {
            if (transform.position.y < 4.880981f)
            {
                transform.Translate(0, speed, 0);
            }
        }
        if (Input.GetKey(down))
        {
            if (transform.position.y > -2.900981f)
            {
                transform.Translate(0, -speed, 0);
            }
        }

        if (BallScript.player1Score == BallScript.pointsToWin 
         || BallScript.player2Score == BallScript.pointsToWin)
        {
            gameObject.SetActive(false);
        }
	}
}
