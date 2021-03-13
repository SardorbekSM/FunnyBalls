using UnityEngine;

public class AreaChecker : MonoBehaviour
{
    [SerializeField]
    private UnityGameObjectEvent _notify;

    private void OnTriggerExit2D(Collider2D collision)
    {
        _notify?.Invoke(collision.gameObject);
    }

}
