using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private Vector3 _initPosition;

    private void Awake()
    {
        _initPosition = transform.position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _initPosition.x += _speed * Time.deltaTime;
        transform.position = _initPosition;
    }
}
