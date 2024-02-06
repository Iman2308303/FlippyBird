using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    public TMP_Text ScoreUI;
    private ScoreManager _scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
        ScoreUI = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_scoreManager == null || ScoreUI == null)
            return;
        
        ScoreUI.text = _scoreManager.Score.ToString();
        
        
    }
}
