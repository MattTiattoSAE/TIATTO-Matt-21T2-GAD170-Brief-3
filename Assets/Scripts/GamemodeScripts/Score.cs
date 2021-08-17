using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Score
{
    public Slider scoreSlider; // UI reference to the score slider 
    public GameObject oddball; // reference to the Oddball prefab

    public float score; // difference between both scores
    public float startingScore = 0.5f; // the score at the start of the round
    public int maxScore = 5; // the maximum score per round

    // called at the start of every round
    public void Setup()
    {
        score = startingScore; // set the score of the game to the starting score
        UpdateScoreUI(); // update the UI with new value
    }

    // called every time the score is updated
    public void UpdateScoreUI()
    {
        scoreSlider.value = score; // set the value of score slider to the value of score
    }
}
