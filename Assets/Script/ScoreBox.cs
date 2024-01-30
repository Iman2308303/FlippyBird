using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    public int ScoreAmount = 10;
    private ScoreManager _scoreManager;

    void Start()
    {
         _scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (_scoreManager == null)
            return;

        _scoreManager.AddScore(ScoreAmount);
        Debug.Log("Add Score" + ScoreAmount);
    }


}
