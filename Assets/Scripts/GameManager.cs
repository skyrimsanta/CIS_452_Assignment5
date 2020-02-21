/*
 * (Levi Schoof)
 * (GameManager)
 * (Assignment 5)
 * (Handles the behind the scenes of the game)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text timer;
    private float gameTime = 30;
    private string remainingTimeText;

    public GameObject inGameText;
    public GameObject endText;
    RandomTargetChange scoreKeepr;

    private int goal = 20;

    private void Start()
    {
        scoreKeepr = FindObjectOfType<RandomTargetChange>();
        Time.timeScale = 0;
        inGameText.SetActive(true);
        endText.SetActive(false);
    }
    void Update()
    {
        if(Time.timeScale < 1 & !endText.activeSelf & Input.anyKey)
        {
            Time.timeScale = 1;
        }
        InGameTimer();
        EndGame();
    }

    private void InGameTimer()
    {
        gameTime -= Time.deltaTime;
        remainingTimeText = gameTime.ToString("F2");
        timer.text = "Time Left: " + remainingTimeText;
    }

    private void EndGame()
    {
        if(gameTime <= 0)
        {
            Time.timeScale = 0;
            endText.SetActive(true);
            inGameText.SetActive(false);
            if(scoreKeepr.GetScore() > goal)
            {
                endText.transform.GetChild(0).GetComponent<Text>().text = "You Won";
            }

            else
            {
                endText.transform.GetChild(0).GetComponent<Text>().text = "You Lost";
            }
        
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
