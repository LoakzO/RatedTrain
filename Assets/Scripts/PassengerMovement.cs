using UnityEngine;

public class PassengerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    public bool ready;

    void Start()
    {
        
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
}
