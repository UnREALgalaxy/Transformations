using UnityEngine;

public class Resizer : MonoBehaviour
{
    [SerializeField, Range(-15, 15)] private float _speed = 0.1f;

    private void Update()
    {
        ChangeSize();
    }

    private void ChangeSize()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}
