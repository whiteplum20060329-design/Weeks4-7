using UnityEngine;

public class pawmove : MonoBehaviour
{

    // While working on this part, I got confused about how to destroy the rock,
    // because at first I thought I must store a GameObject reference directly.


    // After rewatching the tutorial and searching about GameObject,
    // I learned that every Transform actually belongs to a GameObject,
    // and I can access it by using transform.gameObject.

    // This means I only need to store the rock's Transform (rockpos),
    // and when the bullet hits, I can destroy the rock using
    // Destroy(rockpos.gameObject).
    public float speed;
    public float shootdistance;
     public Transform rockpos;
 

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.up * speed * Time.deltaTime;


        if (Vector2.Distance(transform.position, rockpos.position) < shootdistance)
        // Each frame, I calculate the distance between the bullet
        // and the rock using Vector2.Distance.
        {
            Destroy(gameObject);
            Destroy(rockpos.gameObject);

            // If the distance is smaller than shootdistance,
            // it means the bullet hit the rock,
            // so both the bullet and the rock are destroyed.
        }
        else
        {
            Destroy(gameObject, 2);// If the bullet does not hit anything,
                                   // it will automatically destroy itself after 2 seconds
                                   // to avoid too many bullets staying in the scene.
        }

    }
}
