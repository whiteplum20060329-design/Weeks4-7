using UnityEngine;
using UnityEngine.UI;

public class healthtbar : MonoBehaviour
{
    public Slider health;
    public pawshoot pawshoot;
    public Transform cat;
    public float boom;
    public Gamestart Gamestart;
    // This script checks if the rock hits the cat and reduces the HP.
    // health is a UI Slider used as the health bar.
    // pawshoot is referenced so we can get the current spawned rock.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Vector2.Distance(pawshoot.currentrock.position, cat.position) < boom)
            // If the distance between the rock and the cat is smaller than boom,
                                                                                 
            // the rock will be destroyed and the health will decrease.
        {
            Destroy(pawshoot.currentrock.gameObject);
            health.value -= 1f;
        }
        if(health.value == 0)
        {// When health reaches 0, the game returns to the start screen.
            Gamestart.notstart();
        }
    }
}
