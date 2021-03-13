using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    public void Select(int index)
    {
        SceneManager.LoadScene(index);
    }
}
