using UnityEngine;

public class Train : MonoBehaviour
{
    [SerializeField] float acceleration = 0;
    [SerializeField] Accelerator accelerator; 
    float peak = 3;

    void Start()
    {
        
    }

    void Update()
    {
        Accelerate();
        Move();
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
}
