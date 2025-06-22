using UnityEngine;

public class PassengerCollision : MonoBehaviour
{
    [Header("Refs")]
    PassengerMovement objMovement;
    SatisbarFill barFill;

    void Start()
    {
        objMovement = GetComponent<PassengerMovement>();
        barFill = GameObject.Find("Satisbar").GetComponent<SatisbarFill>();
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
            barFill.Fill(0.1f);
            Destroy(gameObject);
        }
    }
}
