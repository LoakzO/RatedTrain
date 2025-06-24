using UnityEngine;

public class PassengerMovement : MonoBehaviour
{
    [Header("Atributes")]
    [SerializeField] float speed;

    [Header("State")]
    public bool ready;

    void Start()
    {
        SetSpeed();
    }

    void Update()
    {
        Board();
    }

    void Board()
    {
        if (ready)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }

    void SetSpeed()
    {
        speed = Random.Range(0.1f, 1);
    }
}
