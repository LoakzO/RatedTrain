using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    [Header("Atributes")]
    [SerializeField] float acceleration = 0;
    [SerializeField] float peak = 2;

    [Header("Refs")]
    [SerializeField] Accelerator accelerator; 

    [Header("State")]
    public bool stopped;

    void Start()
    {
        
    }

    void Update()
    {
        Accelerate();
        Move();
        MovingState();
    }

    void Move()
    {
        transform.Translate(Vector2.left * Time.deltaTime * acceleration);
    }

    void Accelerate()
    {
        if (accelerator.pressing)
        {
            if(acceleration < peak)
            {
                acceleration += accelerator.speed * Time.deltaTime;
            }
        }
        else
        {
            if(acceleration > 0)
            {
                acceleration -= Time.deltaTime / 2;
            }
            else
            {
                acceleration = 0;
            }
        }
    }

    void MovingState()
    {
        if(acceleration > 0)
        {
            stopped = false;
        }
        else
        {
            stopped = true;
        }
    }
}
