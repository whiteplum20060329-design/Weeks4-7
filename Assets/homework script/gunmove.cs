using UnityEngine;

public class gunmove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotate(float rotategun)
    {
        transform.eulerAngles =new Vector3 (0,0,-rotategun);
    }
}
