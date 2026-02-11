using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class rock : MonoBehaviour
{
    public GameObject Prefab;
    public float waitDuration;
    private float waitprogress = 0f;
    public Transform cat;
   public bool ableSpawn=true;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waitprogress += Time.deltaTime;// Instead of spawning all rocks at once,
                                       // a timer is used so rocks appear periodically.
        if ((waitprogress > waitDuration))
        {
            GameObject rock = Instantiate(Prefab, transform.position, Quaternion.identity);
            //ableSpawn = false;
            rockmove rockmove = rock.GetComponent<rockmove>();
            SpriteRenderer rockrenderer= rock.GetComponent<SpriteRenderer>();
            // A random color is assigned to each rock
            // to add visual variety and avoid repetition.
            rockrenderer.color = Random.ColorHSV();
            // After spawning, the rock's movement script is accessed
            // so the the cat can be assigned.
            rockmove.end= cat;
            // The rock is also moved to a random position
            // so that each spawn feels different.
            rockmove.transform.position = Vector3.one * Random.insideUnitCircle * 10;
            waitprogress = 0f;




         

        }

        // I use a timer to spawn rocks at fixed time intervals
        // because spawning too many rocks at once would make the game too difficult.
      

        // Although the later gameplay systems are not fully implemented yet,
        // I already considered how spawning frequency affects player experience.
       
        // Spawning only one or two rocks at a time creates a more manageable pace,
    



    }
}
