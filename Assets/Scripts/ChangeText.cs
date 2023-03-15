using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] Text _scoreText;

    void Start()
    {
        _scoreText.text = "Targets Hit: " + 0;
    }

    public void updateScore(int playerScore)
    {
        _scoreText.text = "Targets Hit: " + playerScore;
    }
}
