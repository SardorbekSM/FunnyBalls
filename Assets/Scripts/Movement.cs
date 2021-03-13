using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private Vector3 _position;

    private void Start()
    {
        _position = transform.position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _position.x += _speed * Time.deltaTime;
        transform.position = _position;
    }
}
