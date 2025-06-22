using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Atributes")]
    [SerializeField] float speed = 7;

    [Header("Refs")]
    [SerializeField] GameObject train;

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
