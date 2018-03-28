using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    Rigidbody rb;
    Vector3 oldVelocity;
    public float ballStart;

    public static int player1Score;
    public static int player2Score;

    public static int pointsToWin;

    float randomNumber1;
    float randomNumber2;

    AudioSource hitSound;

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint cp = collision.contacts[0];

        hitSound.Play();

        rb.velocity = Vector3.Reflect(oldVelocity, cp.normal);

        if (rb.velocity.x < 10 && rb.velocity.x > -10 
            && rb.velocity.y < 10 && rb.velocity.y > -10)
        {
            rb.velocity += cp.normal;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "score1")
        {
            player1Score++;
        }

        if(other.tag == "score2")
        {
            player2Score++;
        }

        SceneManager.LoadScene("MainLevel");
    }

    // Use this for initialization
    void Start ()
    {
        if (pointsToWin <= 0)
        {
            pointsToWin = 7;
        }

        hitSound = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();

        randomNumber1 = Random.Range(-1f, 1f);
        randomNumber2 = Random.Range(-1f, 1f);

        if(randomNumber1 > .5f || randomNumber1 < -.5f 
        && randomNumber2 > .5f || randomNumber2 < -.5f )
        {
            rb.AddForce(ballStart * randomNumber1, ballStart * randomNumber2, 0);
        }
        else
        {
            rb.AddForce(ballStart, ballStart, 0);
            Debug.Log("Hit");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        oldVelocity = rb.velocity;

        if (player1Score == pointsToWin || player2Score == pointsToWin)
        {
            gameObject.SetActive(false);
        }
	}
}
