using System;
using UnityEngine;

public class TrainBehavior : MonoBehaviour
{
    [Header("Refs")]
    [SerializeField] SatisbarFill satisbar;
    [SerializeField] Timer timer;

    TrainMovement trainMovement;

    [Header("State")]
    public bool atStation;


    void Start()
    {
        trainMovement = GetComponent<TrainMovement>();
    }

    void Update()
    {
        CheckStation();
    }

    void CheckStation()
    {
        if(trainMovement.stopped && !atStation)
        {
            satisbar.Deflate(0.001f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Station")
        {
            timer.AddTime(10);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Station")
        {
            atStation = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        atStation = false;
    }
}
