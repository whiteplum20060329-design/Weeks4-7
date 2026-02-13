using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gunmove : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI slidervalue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slidervalue.text = slider.value.ToString();
    }

    public void rotate(float rotategun)
    {
        transform.eulerAngles =new Vector3 (0,0,-rotategun);
    }
}
