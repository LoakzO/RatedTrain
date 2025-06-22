using UnityEngine;
using UnityEngine.UI;

public class SatisbarFill : MonoBehaviour
{
    [Header("Refs")]
    [SerializeField] Image imgFill;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Fill(float valor)
    {
        imgFill.fillAmount += valor;
    }

    public void Deflate(float valor)
    {
        imgFill.fillAmount -= valor;
    }
}
