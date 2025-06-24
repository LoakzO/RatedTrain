using UnityEngine;
using UnityEngine.UI;

public class LevelEarnings : MonoBehaviour
{
    [SerializeField]Text coinsTxt;
    CoinManager coinManager;
    SatisbarFill satisbar;
    Timer timer;

    void Start()
    {
        coinManager = GameObject.Find("Setup").GetComponent<CoinManager>();
        satisbar = GameObject.Find("Satisbar").GetComponent<SatisbarFill>();
        timer = GameObject.Find("Timer").GetComponent<Timer>();

        EarnCoins();
    }

    void Update()
    {
        ShowCoins();
    }

    void EarnCoins()
    {
        coinManager.AddCoins(Sum());
    }

    int Sum()
    {
        float barValor = satisbar.GetFill() * 10;
        return (int)(barValor + timer.time);
    }

    void ShowCoins()
    {
        coinsTxt.text = "+" + Sum();
    }
}
