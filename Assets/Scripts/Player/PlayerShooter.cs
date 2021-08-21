using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Transform _shootPoint;

    private void OnEnable()
    {
        Input.Inputs.Player.Shoot.performed += ctx => OnShoot();
    }

    private void OnDisable()
    {
        Input.Inputs.Player.Shoot.performed -= ctx => OnShoot();
    }

    private void OnShoot()
    {
        Instantiate(_bullet, _shootPoint.position, _shootPoint.rotation); 
    }
    
}
