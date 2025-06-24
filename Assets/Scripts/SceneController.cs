using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
