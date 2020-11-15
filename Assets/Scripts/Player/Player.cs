using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _score = 0;

    public event UnityAction<int> ScoreChanged;
    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;

    private void Start()
    {
        ScoreChanged?.Invoke(_score);
        HealthChanged?.Invoke(_health);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Asteroid>(out Asteroid asteroid))
            ApplyDamage();
    }

    private void ApplyDamage()
    {
        _health--;
        HealthChanged?.Invoke(_health);
        if(_health <= 0)
        {
            Died?.Invoke();
            gameObject.SetActive(false);
        }
    }

    public void GetScore(int reward)
    {
        _score += reward;
        ScoreChanged?.Invoke(_score);
    }

}
