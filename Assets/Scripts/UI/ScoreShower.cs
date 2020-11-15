using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreShower : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _player.ScoreChanged += ChangingScore;
    }

    private void OnDisable()
    {
        _player.ScoreChanged -= ChangingScore;
    }

    private void ChangingScore(int score)
    {
        _text.text = score.ToString();
    }
}
