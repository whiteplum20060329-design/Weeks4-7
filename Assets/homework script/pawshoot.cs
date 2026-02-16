using Mono.Cecil;
using UnityEngine;
using UnityEngine.InputSystem;

public class pawshoot : MonoBehaviour
{

    // I realized that the rock spawner and the shooting system needed to be written together,
    // because the bullet needs to know which rock it should target.
  
    // When these were separated into different scripts, it was hard for me to pass the rock reference
    // to the bullet prefab correctly.
  

    // So I combined both prefab controls into one script
    // then passes that rock transform to the bullet when shooting.
    public GameObject Prefabpaw;
  
    public Transform fireshoot;

    public Transform gun;


    public GameObject Prefab;
    public float waitDuration;
    private float waitprogress = 0f;
    public Transform cat;

    public Transform currentrock;
    // currentrock stores the most recently spawned rock,
    // so the bullet can aim at it later.


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
            waitprogress += Time.deltaTime;// Instead of spawning all rocks at once,
                                           // a timer is used so rocks appear periodically.

            //Vector3 offscreen = new Vector3(100, 0, 0);
            //GameObject paw = Instantiate(Prefabpaw, offscreen, transform.rotation);
            //pawmove pawmove = paw.GetComponent<pawmove>();


            //I left this wrong idea for recording, because I found that I had to move these two prefabricated parts
            //into a script, and they had to have a certain position order so that they could get some information
            //from each other. So at the beginning, I thought of this method to generate a lot of paws,
            //but only when the keyboard was clicked down in that frame, he would move to the position of the gun,
            //forming such a fake effect of shooting. But later I found that this actually didn't work.
            //Because countless paws were generated,
            //my distance judgment was completely chaotic, so my distance judgment could not take effect.


            // a timer is used so rocks appear periodically.
            if ((waitprogress > waitDuration))
            {
                GameObject rock = Instantiate(Prefab, transform.position, Quaternion.identity);

                rockmove rockmove = rock.GetComponent<rockmove>();

                SpriteRenderer rockrenderer = rock.GetComponent<SpriteRenderer>();



                // A random color is assigned to each rock
                // to add visual variety and avoid repetition.
                rockrenderer.color = Random.ColorHSV();
                // After spawning, the rock's movement script is accessed
                // so the the cat can be assigned.
                rockmove.end = cat;
                // The rock is also moved to a random position
                // so that each spawn feels different.
                rockmove.transform.position = Vector3.one * Random.insideUnitCircle * 10;
                waitprogress = 0f;

                currentrock = rock.transform;

                // I use a timer to spawn rocks at fixed time intervals
                // because spawning too many rocks at once would make the game too difficult.


                // Although the later gameplay systems are not fully implemented yet,
                // I already considered how spawning frequency affects player experience.

                // Spawning only one or two rocks at a time creates a more manageable pace,

            
        }
    }
       public void Shoot()
        {
          
            GameObject paw = Instantiate(Prefabpaw, fireshoot.position, gun.rotation);
        // In Shoot(), I instantiate a bullet at the fireshoot position.
        pawmove pawmove = paw.GetComponent<pawmove>();
            pawmove.rockpos = currentrock;
        // Then I get the pawmove script from the bullet and assign its rock target using currentrock.
    }

}
  