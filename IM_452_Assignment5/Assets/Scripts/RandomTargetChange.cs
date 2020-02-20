using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomTargetChange : MonoBehaviour
{
    Target[] targets;
    float changeTime = 2;
    float currentTime = 0;

    public Text scoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        targets = FindObjectsOfType<Target>();
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > changeTime)
        {
            currentTime = 0;
            TurnOnRanTarget();
        }
    }

    private void TurnOnRanTarget()
    {
        int temp = Random.Range(0, targets.Length);
        targets[temp].TurnOn(changeTime);

    }

    public void ChangeScore(int nun)
    {
        score += nun;

        scoreText.text = "Score: " + score;
    }

    public int GetScore()
    {
        return score;
    }
}
