using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public float speed = 2f;

    private bool isMoving = false;
    private float direction = 1f;

    void Update()
    { // isMoving is a boolean used to check whether the object should move or not.
      // Using a boolean allows the movement to be turned on or off easily
        if (isMoving)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }
    }


    // This function is called when the Move button is clicked.
    // It sets isMoving to true, which allows the object to start moving.
  
    public void OnMoveClick()
    {
        isMoving = true;
       
    }
    // This function is called when the Stop button is clicked.
    // It sets isMoving to false, which immediately stops the movement
    public void OnStopClick()
    {
        isMoving = false;
    }

    
    public void OnFlipClick()
    {
        direction *= -1;

      
    }
}
