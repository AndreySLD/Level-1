using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _speedRotation = 5f;
    private Vector3 _direction;
    private float _angle = 0;
    public int count = 0;
    private void Awake()
    {
        _direction = Vector3.zero;
    }
    void Update()
    {
        _direction.x = Input.GetAxis("Vertical");
        _direction.z = Input.GetAxis("Horizontal") * -1;

        _angle = Input.GetAxis("Mouse X");
    }
    private void FixedUpdate()
    {
        var speed = _direction.normalized * _speed * Time.fixedDeltaTime;
        transform.Translate(speed);

        transform.Rotate(Vector3.up * _speedRotation * _angle * Time.fixedDeltaTime);
    }
}
