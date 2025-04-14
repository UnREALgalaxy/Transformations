using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField, Range(-15, 15)] private float _speed = 8;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
