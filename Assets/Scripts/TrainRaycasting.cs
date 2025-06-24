using UnityEngine;

public class TrainRaycasting : MonoBehaviour
{
    [Header("Refs")]
    [SerializeField] Transform raycaster;
    [SerializeField] GameObject stationAlert;

    TrainBehavior train;

    void Start()
    {
        train = GetComponent<TrainBehavior>();
    }

    void Update()
    {
        CheckDistance();
    }

    void CheckDistance()
    {
        Ray ray = new Ray(raycaster.position, Vector2.left);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, float.MaxValue);
        Debug.DrawRay(ray.origin, ray.direction * 1000, Color.magenta); //DEV

        if(hit.collider != null)
        {
            if (hit.collider.tag == "Station" || hit.collider.tag == "TerminalStation")
            {
                if(Vector2.Distance(transform.position, hit.collider.transform.position) <= 10)
                {
                    stationAlert.SetActive(!train.atStation);
                }
            }
        }
    }
}
