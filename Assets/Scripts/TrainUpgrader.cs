using UnityEngine;

public class TrainUpgrader : MonoBehaviour
{
    [SerializeField] GameObject wagon;
    [SerializeField] Upgrade wagonUpgrade;

    TrainBehavior train;

    void Start()
    {
        train = GetComponent<TrainBehavior>();

        AddWagon(wagonUpgrade, wagon);
    }

    void Update()
    {
        
    }

    void AddWagon(Upgrade wagonUp, GameObject wagon)
    {
        if (wagonUp.active)
        {
            wagon.SetActive(true);
            train.capacity += 5;
        }
        else
        {
            print("Sem vagões pra vc!");
        }
    }
}
