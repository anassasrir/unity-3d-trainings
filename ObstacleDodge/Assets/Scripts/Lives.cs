using System;
using UnityEngine;

public class Lives : MonoBehaviour
{
    int remainingLives = 5;

    void LoseLife() 
    {
        remainingLives--;
        Debug.Log("Lives remaining: " + remainingLives);
        GameOver();
    }

    void GameOver()
    {
        if (remainingLives <= 0)
        {
            Debug.Log($"Game Over! You played for {Convert.ToInt32(Time.time)}s");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (remainingLives > 0)
            LoseLife();
    }
}
