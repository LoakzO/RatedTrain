using UnityEngine;
using UnityEngine.UI;

public class SatisbarFill : MonoBehaviour
{
    [Header("Refs")]
    [SerializeField] Image imgFill;
    
    GameSetup setup;
    Animator satisbarAnimator;

    void Start()
    {
        setup = GameObject.Find("Setup").GetComponent<GameSetup>();
        satisbarAnimator = GetComponent<Animator>();
    }

    
    void Update()
    {
        CheckFill();
        AnimateAlarm(false);
    }

    public void Fill(float amount)
    {
        imgFill.fillAmount += amount;
    }

    public void Deflate(float amount)
    {
        imgFill.fillAmount -= amount * Time.deltaTime;
        AnimateAlarm(true);
    }

    void CheckFill()
    {
        if(imgFill.fillAmount == 0 && Time.timeScale == 1)  //XD
        {
            setup.Fail();
        }
    }

    public float GetFill()
    {
        return imgFill.fillAmount;
    }

    void AnimateAlarm(bool value)
    {
        satisbarAnimator.SetBool("pDeflating", value);
    }
}
