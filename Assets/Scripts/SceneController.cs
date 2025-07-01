using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

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
        StartCoroutine(LoadScene(1, sceneName));
    }

    IEnumerator LoadScene(float delay, string name)
    {
        yield return new WaitForSecondsRealtime(delay);
        SceneManager.LoadScene(name);
    }
}
