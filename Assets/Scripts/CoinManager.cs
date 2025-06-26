using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField]int coins = 0;

    void Start()
    {
        LoadCoins();
    }

    void Update()
    {
        ResetCoins(); //DEV
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        SaveCoins();
    }

    public void RemoveCoins(int amount)
    {
        coins -= amount;
        SaveCoins();
    }

    void SaveCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
    }

    void LoadCoins()
    {
        coins = PlayerPrefs.GetInt("Coins", 0);
    }

    //DEV
    void ResetCoins()
    {
        if (Input.GetButtonDown("Jump"))
        {
            coins = 0;
            SaveCoins();
        }
    }

    public int GetCoins()
    {
        return coins;
    }
}
