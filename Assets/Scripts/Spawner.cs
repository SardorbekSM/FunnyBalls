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

    private Vector3 _randomPoint;

    private void Awake()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            _randomPoint.x = Random.Range(_pointA.x, _pointB.x);
            _randomPoint.y = Random.Range(_pointA.y, _pointB.y);
            _randomPoint.z = _pointB.z;

            Instantiate(_gameObject, _randomPoint, Quaternion.Euler(0, 0, 0));
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


