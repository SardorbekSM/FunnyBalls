using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    public void SelectScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
