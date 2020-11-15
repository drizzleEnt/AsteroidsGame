using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthShower : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _player.HealthChanged += OnPlayerHealthChange;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnPlayerHealthChange;
    }

    private void OnPlayerHealthChange(int health)
    {
        _text.text = health.ToString();
    }
}
