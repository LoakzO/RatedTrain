using UnityEngine;

public class PassengerCollision : MonoBehaviour
{
    PassengerMovement objMovement;

    void Start()
    {
        objMovement = GetComponent<PassengerMovement>();
    }

    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Train")
        {
            if (collision.GetComponent<TrainMovement>().stopped)
            {
                objMovement.ready = true;
            }
            else
            {
                objMovement.ready = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Train")
        {
            Destroy(gameObject);
        }
    }
}
