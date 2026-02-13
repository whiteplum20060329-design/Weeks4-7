using UnityEngine;
using UnityEngine.InputSystem;

public class tank : MonoBehaviour
{
    public float speed;

    private float direction = 1f;

    public SpriteRenderer sprite;
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

        Vector3 Pos = Camera.main.WorldToScreenPoint(transform.position);

        if (Pos.x > Screen.width)
        {

            Pos.x = Screen.width;
        }
        if (Pos.x < 0)
        {

            Pos.x = 0;

        }

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Pos);

        worldPos.z = 0;
        transform.position = worldPos;



    }


    public void speedchange()
    {
        speed++;
    }

    public void colorchange()
    {
        sprite.color = Random.ColorHSV();
    }


}