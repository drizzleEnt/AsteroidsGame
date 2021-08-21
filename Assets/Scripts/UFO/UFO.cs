using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Init(Player player)
    {
        _target = player.transform;
    }

    private void FixedUpdate()
    {
        MoveToPlayer(_target);
    }

    private void MoveToPlayer(Transform target)
    {
        var direction = (target.position - transform.position).normalized;
        //_rigidbody.AddForce(direction * 5 * Time.deltaTime, ForceMode2D.Impulse);
        _rigidbody.velocity = direction * 5;
    }
}
