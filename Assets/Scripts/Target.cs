/*
 * (Levi Schoof)
 * (Target)
 * (Assignment 5)
 * (Handles the random color of the pillar and the collision)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    bool red;
    bool blue;
    private SpriteRenderer sr;
    public Text scoreText;
    int score;

    RandomTargetChange manager;

    private void Start()
    {
        manager = FindObjectOfType<RandomTargetChange>();
        sr = this.GetComponent<SpriteRenderer>();
        sr.color = Color.white;
        score = 0;
        scoreText.text = "Score: " + score;
    }

    public void TurnOn(float length)
    {
        int temp = Random.Range(0, 2);
        if(temp == 0)
        {
            sr.color = Color.blue;
            blue = true;
        }

        else
        {
            sr.color = Color.red;
            red = true;
        }
        Invoke("TurnOff", length);
    }

    public void TurnOff()
    {
        blue = false;
        red = false;
        sr.color = Color.white;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (blue)
        {
            if (collision.gameObject.GetComponent<BlueBullet>())
            {
                manager.ChangeScore(1);
            }

            if (collision.gameObject.GetComponent<RedBullet>())
            {
                manager.ChangeScore(-1);
            }
        }

        else if (red)
        {
            if (collision.gameObject.GetComponent<BlueBullet>())
            {
                manager.ChangeScore(-1);
            }

            if (collision.gameObject.GetComponent<RedBullet>())
            {
                manager.ChangeScore(1);
            }
        }

        Destroy(collision.gameObject);
    }
}
