using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int Score = 0;
    // Start is called before the first frame update
    public void AddScore(int score)
    {
        Score += score;
        Debug.Log("current score" + score);
    }
}
