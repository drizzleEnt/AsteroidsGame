using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : AsteroidsPool
{
    [SerializeField] private List<Asteroid> _asteroids;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime = 0f;

    private void Start()
    {
        
        for (int i = 0; i < _asteroids.Count; i++)
        {
           Initialized(_asteroids);
            
        }
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _secondsBetweenSpawn)
        {
            if (TryGetObject(out Asteroid asteroid))
            {
                _elapsedTime = 0;
                SetEnemy(asteroid, transform.position);
            }
        }
    }

    private void SetEnemy(Asteroid asteroid, Vector2 spawnPosition)
    {
        float randomOffsetPosition = Random.Range(-5, 5);
        asteroid.gameObject.SetActive(true);
        asteroid.transform.position = new Vector2 (spawnPosition.x , randomOffsetPosition);
    }

}
