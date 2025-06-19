using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]float speed = 7;
    [SerializeField]GameObject train;

    void Start()
    {
        
    }

    void Update()
    {
        Follow();
    }

    void Follow()
    {
        if(train.transform.position.x <= 0)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(train.transform.position.x, transform.position.y, transform.position.z), speed * Time.deltaTime);
        }
    }
}
