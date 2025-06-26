using System;
using UnityEngine;

public class TrainBehavior : MonoBehaviour
{
    [Header("Atributes")]
    public int capacity;
    public int numPassengers = 0;   //improve

    int passengersChecker;

    [Header("Refs")]
    [SerializeField] SatisbarFill satisbar;
    [SerializeField] Timer timer;

    TrainMovement trainMovement;
    GameSetup setup;

    [Header("State")]
    public bool atStation;

    void Start()
    {
        trainMovement = GetComponent<TrainMovement>();
        setup = GameObject.Find("Setup").GetComponent<GameSetup>();
    }

    void Update()
    {
        CheckStation();
        CheckCapacity();
        CheckTimetable();
    }

    void CheckStation()
    {
        if(trainMovement.stopped && !atStation)
        {
            satisbar.Deflate(0.1f);
        }
    }

    void CheckCapacity()
    {
        if(numPassengers > capacity)
        {
            satisbar.Deflate(0.1f);
        }
    }

    void CheckTimetable()
    {
        if(timer.time <= 0)
        {
            satisbar.Deflate(0.1f);
        }
    }

    void CheckPassengers()
    {
        if(passengersChecker == numPassengers)
        {
            setup.Fail();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Station")
        {
            timer.AddTime(10);
            passengersChecker = numPassengers;
        }
        else if (collision.gameObject.tag == "Passenger")
        {
            numPassengers += 1;
        }
        else if(collision.gameObject.tag == "TerminalStation")
        {
            timer.SetGoing(false);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Station" || collision.gameObject.tag == "StartStation")
        {
            atStation = true;
        }
        else if(collision.gameObject.tag == "TerminalStation")
        {
            if (trainMovement.stopped)
            {
                setup.LevelComplete();
            }
            atStation = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Station")
        {
            CheckPassengers();
            atStation = false;
        }
        else if(collision.gameObject.tag == "StartStation")
        {
            atStation = false;
            timer.SetGoing(true);
        }
        else if(collision.gameObject.tag == "TerminalStation")
        {
            setup.Fail();
        }
    }
}
