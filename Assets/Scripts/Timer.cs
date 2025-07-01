using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    Text timerText;

    bool going;

    Animator timerAnimator;

    void Start()
    {
        timerText = GetComponent<Text>();
        timerAnimator = GetComponent<Animator>();
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
        timerAnimator.SetTrigger("pSum");
        time += amount;
    }

    public void SetGoing(bool value)
    {
        going = value;
    }
}
