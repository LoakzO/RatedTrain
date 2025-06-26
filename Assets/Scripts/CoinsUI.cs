using UnityEngine;
using UnityEngine.UI;
public class CoinsUI : MonoBehaviour
{
    [SerializeField] Text coinText;

    CoinManager coinManager;

    void Start()
    {
        coinManager = GetComponent<CoinManager>();
    }

    void Update()
    {
        ShowCoins(coinManager.GetCoins());
    }

    void ShowCoins(int value)
    {
        coinText.text = value.ToString();
    }
}
