using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    //TODO Show Lives, Reduce Lives, Add Danger
    
    private int _score = 0;
    [SerializeField] private Text _scoreText;


    void Start()
    {
        _scoreText.text = "Score: " + _score;
    }

    public void AddScore(int score)
    {
        _score += score;
        _scoreText.text = "Score: " + _score;
    }
}
