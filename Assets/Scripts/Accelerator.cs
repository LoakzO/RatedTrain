using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Accelerator : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [Header("Atributes")]
    public float speed;

    [Header("Refs")]
    [SerializeField] Image imgFill;

    [Header("State")]
    public bool pressing;

    void Start()
    {
        
    }

    void Update()
    {
        FillButton();
    }

    void FillButton()
    {
        if (pressing)
        {
            imgFill.fillAmount += Time.deltaTime / 2;
        }
        else
        {
            imgFill.fillAmount -= Time.deltaTime / 2;
        }

        speed = imgFill.fillAmount;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressing = false;
    }
}
