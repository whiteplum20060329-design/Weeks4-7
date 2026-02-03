using UnityEngine;

public class Spinner : MonoBehaviour
{// This variable controls the rotation speed.
    // If speed is 0, the object will not rotate.
    // If speed is greater than 0, the object will rotate.
    public float speed = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.eulerAngles represents the current rotation of the object.
        transform.eulerAngles += new Vector3(0f, 0f, speed) * Time.deltaTime;
    }

    // This public function is called by the ON button.
    // It sets the speed to a positive value so the object starts rotating.
    public void StartSpin()
    {
        speed = 100f;
    }

    // This public function is called by the OFF button.
    // It sets the speed to 0 so the object stops rotating.
    public void StopSpin()
    {
        speed = 0f;
    }
}
