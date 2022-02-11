using UnityEngine;
using UnityEngine.SceneManagement;

public class Testing : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("second-scene", LoadSceneMode.Additive);
    }
}
