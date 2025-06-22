using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float time;
    Text timerText;

    void Start()
    {
        timerText = GetComponent<Text>();
    }

    void Update()
    {
        ShowText();
        CountDown();
    }

    void ShowText()
    {
        timerText.text = time.ToString("F0");
    }

    void CountDown()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
        }
    }

    public void AddTime(float valor)
    {
        time += valor;
    }
}
