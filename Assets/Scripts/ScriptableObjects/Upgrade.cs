using UnityEngine;

[CreateAssetMenu(fileName = "Upgrade", menuName = "Upgrades/New Upgrade")]
public class Upgrade : ScriptableObject
{
    public bool active = false;
    public int cost;
    public string upgradeName;
}
