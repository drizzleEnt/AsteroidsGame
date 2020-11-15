using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Transform _shootPoint;

    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
        _playerInput.Player.Shoot.performed += ctx => OnShoot();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
        _playerInput.Player.Shoot.performed -= ctx => OnShoot();
    }

    private void OnShoot()
    {
        Instantiate(_bullet, _shootPoint.position, _shootPoint.rotation); 
    }
    
}
