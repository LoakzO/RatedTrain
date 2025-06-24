using UnityEngine;

public class GameSetup : MonoBehaviour
{
    [Header("State")]
    bool paused = false;

    [Header("Refs")]
    [SerializeField] GameObject gameoverPanel;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject completePanel;

    void Start()
    {
        Time.timeScale = 1;
        paused = false;
    }

    void Update()
    {
        
    }

    void FreezeTime()
    {
        if (!paused)
        {
            Time.timeScale = 0;
            paused = true;
        }
        else
        {
            Time.timeScale = 1;
            paused = false;
        }
    }

    public void Fail()
    {
        FreezeTime();
        gameoverPanel.SetActive(true);
    }

    public void Pause()
    {
        FreezeTime();
        pausePanel.SetActive(paused);
    }

    public void LevelComplete()
    {
        FreezeTime();
        completePanel.SetActive(true);
    }
}
