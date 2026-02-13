using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;

    private float direction = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -1 * direction * transform.up * speed * Time.deltaTime;
    }
}
