using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField, Range(-15, 15)] private float _speed = 8;
    private Vector3 _direction = Vector3.right;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_direction * Time.deltaTime * _speed, Space.Self);
    }
}
