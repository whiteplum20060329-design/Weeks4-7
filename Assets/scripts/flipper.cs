using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public float speed = 2f;

    private bool isMoving = false;
    private float direction = 1f;

    void Update()
    {
        if (isMoving)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }
    }

  
    public void OnMoveClick()
    {
        isMoving = true;
       
    }

    public void OnStopClick()
    {
        isMoving = false;
    }

    
    public void OnFlipClick()
    {
        direction *= -1;

      
    }
}
