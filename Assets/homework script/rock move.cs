using UnityEngine;
using UnityEngine.UIElements;

public class rockmove : MonoBehaviour
{
    
    public Transform end;
    public float progress;
    public Vector3 output;
    public float boomdistance;
   
    
   


    public float duration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Increase progress over time based on duration
        progress += Time.deltaTime / duration;

        // Smoothly move the rock from its current position to the target position
      
        output = Vector3.Lerp(transform.position, end.position, progress);
        transform.position = output;

        Debug.Log(Vector2.Distance(transform.position, end.position));



    
        if (Vector2.Distance(transform.position, end.position) < boomdistance)
        {
            Destroy(gameObject);
        }
        // When the distance becomes smaller than the defined value,
        // the rock is considered to have hit the cat.
        // The rock then destroys itself to simulate the collision effect.
    }
}

// I placed the hit detection logic in this script (rockmove)
// instead of the rock spawner script.


// At first, I tried to check whether the rock hit the cat
// inside the rock spawner script.


// However, I realized that the spawner script only runs
// the check at the moment when the rock is created.


// Since the rock has not moved yet at that time,
// the condition would never be true.


// To solve this problem, I moved the hit detection logic
// into the rock's own movement script.


// This script runs every frame, which allows the rock
// to continuously check its distance to the cat while moving.







