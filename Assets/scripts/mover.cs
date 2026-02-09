using UnityEngine;
using UnityEngine.InputSystem;

public class mover : MonoBehaviour
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
        if (Keyboard.current.aKey.isPressed)
        {
            transform.position += -1 * direction * transform.right * speed * Time.deltaTime;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.position += direction * transform.right * speed * Time.deltaTime;
        }
        if (Keyboard.current.wKey.isPressed)
        {
            transform.position += direction * transform.up * speed * Time.deltaTime;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            transform.position += -1 * direction * transform.up * speed * Time.deltaTime;
        }

    }
}