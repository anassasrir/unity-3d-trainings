using System;
using UnityEngine;

public class Lives : MonoBehaviour
{
    int remainingLives;

    void Start()
    {
        Dodger dodger = FindObjectOfType<Dodger>();
        remainingLives = dodger.maxLives;
    }

    void LoseLife() 
    {
        GameObject gameObject = ObjectHit.collision.gameObject;
        if (gameObject.tag != "Hit" && gameObject.name.Contains("Obstacle"))
        {
            remainingLives--;
            Debug.Log("Remaining lives: " + remainingLives);
        }
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
