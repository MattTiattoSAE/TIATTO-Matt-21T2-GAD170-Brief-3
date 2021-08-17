using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamemodeManager : MonoBehaviour
{
    //public Timer timer; // reference to the timer script
    public Score score = new Score(); // reference to the score script
    


    private void OnEnable()
    {
        TankGameEvents.OnScoreUpdatedEvent += UpdateScore;
    }

    private void OnDisable()
    {
        TankGameEvents.OnScoreUpdatedEvent -= UpdateScore;
    }

    void Start()
    {
        // start setting up all of the game logic
        //timer.Setup();
        score.Setup();
    }

    private void Update()
    {

    }

    public void UpdateScore(PlayerNumber player, int amount)
    {

    }
}
