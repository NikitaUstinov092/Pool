using UnityEngine;


public class BulletMove : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed = 16f;

    private void Update()
    {
        _rigidbody.velocity = _direction.normalized * _speed;
    }
}
