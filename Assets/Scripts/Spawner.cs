using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameObject;

    [SerializeField]
    private float _intensity;

    [SerializeField]
    private Vector3 _pointA;

    [SerializeField]
    private Vector3 _pointB;

    private Vector3 _randomPosition;

    private void Awake()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            _randomPosition.x = Random.Range(_pointA.x, _pointB.x);
            _randomPosition.y = Random.Range(_pointA.y, _pointB.y);
            _randomPosition.z = _pointB.z;

            Instantiate(_gameObject, _randomPosition, Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(_intensity);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector2(_pointA.x, _pointA.y), new Vector2(_pointB.x, _pointA.y));
        Gizmos.DrawLine(new Vector2(_pointA.x, _pointA.y), new Vector2(_pointA.x, _pointB.y));
        Gizmos.DrawLine(new Vector2(_pointB.x, _pointA.y), new Vector2(_pointB.x, _pointB.y));
        Gizmos.DrawLine(new Vector2(_pointA.x, _pointB.y), new Vector2(_pointB.x, _pointB.y));
    }
}


