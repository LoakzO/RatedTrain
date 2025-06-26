using UnityEngine;
using UnityEngine.UI;

public class CapacityFill : MonoBehaviour
{
    [SerializeField] Image capFill;
    [SerializeField] TrainBehavior train;

    void Start()
    {

    }

    void Update()
    {
        FillCapacity();
    }

    void FillCapacity()
    {
        capFill.fillAmount = train.numPassengers / (float)train.capacity;
    }
}
