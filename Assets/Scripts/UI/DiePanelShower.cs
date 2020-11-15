using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiePanelShower : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _diePannel;

    private void OnEnable()
    {
        _player.Died += OnPlayerDie;
    }

    private void OnDisable()
    {
        _player.Died -= OnPlayerDie; 
    }

    private void OnPlayerDie()
    {
        _diePannel.SetActive(true);
        Time.timeScale = 0;
    }
}
