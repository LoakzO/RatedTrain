using UnityEngine;
using UnityEngine.UI;

public class SatisbarFill : MonoBehaviour
{
    [Header("Refs")]
    [SerializeField] Image imgFill;
    
    GameSetup setup;

    void Start()
    {
        setup = GameObject.Find("Setup").GetComponent<GameSetup>();
    }

    
    void Update()
    {
        CheckFill();
    }

    public void Fill(float amount)
    {
        imgFill.fillAmount += amount;
    }

    public void Deflate(float amount)
    {
        imgFill.fillAmount -= amount * Time.deltaTime;
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
}
