using UnityEngine;

public class ClickChecker : MonoBehaviour
{
    [SerializeField]
    private UnityGameObjectEvent _notify;

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
