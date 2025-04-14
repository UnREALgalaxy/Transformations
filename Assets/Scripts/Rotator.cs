using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField, Range(-50, 50)] private float _speed = 8;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, _speed * Time.deltaTime);
    }
}
