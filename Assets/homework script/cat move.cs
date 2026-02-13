using UnityEngine;
using UnityEngine.InputSystem;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class catmove : MonoBehaviour
{
    public float speed;

    private float direction = 1f;

   private float gravity = -0.35f;
    // Gravity strength, controls how strongly the object is pulled downward each frame

    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.aKey.isPressed)
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
       
        transform.position += new Vector3(0, gravity, 0) * Time.deltaTime;//I used a  variable to simulate gravity.
                                                                          // Gravity reduces every frame, creating a natural motion where the object  falls.

        Vector3 Pos= Camera.main.WorldToScreenPoint(transform.position);
        // Convert the object's world position into screen space 
        // We do this so we can check whether the object is outside the screen boundaries
        if (Pos.x > Screen.width)
        {
           
            Pos.x = Screen.width;
        }
        if (Pos.x < 0)
        {
           
            Pos.x = 0;

        }
        if (Pos.y > Screen.height)
        {
           
            Pos.y = Screen.height;
        }
        if (Pos.y < 0)
        {
           
            Pos.y = 0;

        }
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Pos);
        //Convert the clamped screen position back into world space
       // Unity objects must be positioned using world coordinates
        worldPos.z = 0;
        transform.position = worldPos;
    }
}
