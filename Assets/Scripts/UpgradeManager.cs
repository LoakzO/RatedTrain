using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    CoinManager coinManager;

    void Start()
    {
        coinManager = GetComponent<CoinManager>();
    }

    void Update()
    {
        
    }

    public void BuyUpgrade(Upgrade upgrade)
    {
        if(coinManager.GetCoins() >= upgrade.cost)
        {
            upgrade.active = true;
            coinManager.RemoveCoins(upgrade.cost);
        }
        else
        {
            print("Not enough money!");
        }
    }
}
