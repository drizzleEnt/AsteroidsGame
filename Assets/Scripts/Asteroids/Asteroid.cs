using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Asteroid : MonoBehaviour
{
    [SerializeField] private int _reward;
    [SerializeField] private Asteroid _asteroidToSpawn;
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;

    private float _currentlifeTime = 0f;
   

    private Player _target;

    private void Start()
    {
        _target = FindObjectOfType<Player>();
    }

    private void Update()
    {
        _currentlifeTime += Time.deltaTime;
        transform.Translate(transform.right * _speed * Time.deltaTime);
        if (_currentlifeTime >= _lifeTime)
        {
            _currentlifeTime = 0f;
            gameObject.SetActive(false);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Bullet>(out Bullet bullet))
             Die();
        if (collision.TryGetComponent<Player>(out Player player))
            gameObject.SetActive(false);
       
        
    }

    private void DestractionAsteroid()
    {
        if (_asteroidToSpawn != null)
        {
            float _spawnOffset = Random.Range(-1, 1);
            float spawnOffset = Random.Range(0, 360);
            Quaternion offset =Quaternion.Euler(transform.rotation.x, transform.rotation.y , transform.rotation.z + _spawnOffset);
            Quaternion secondOffset = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z + spawnOffset);
            Instantiate(_asteroidToSpawn, transform.position, offset);
            Instantiate(_asteroidToSpawn, transform.position, secondOffset);

        }



    }

    public void Init(Player target)
    {
        _target = target;
    }

    protected virtual void Die()
    {
        DestractionAsteroid();
        _target.GetScore(_reward);
        gameObject.SetActive(false);
    }
}
