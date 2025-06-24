using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    Text timerText;

    bool going;

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
        if(time > 0 && going)
        {
            time -= Time.deltaTime;
        }
    }

    public void AddTime(float amount)
    {
        time += amount;
    }

    public void SetGoing(bool value)
    {
        going = value;
    }
}
