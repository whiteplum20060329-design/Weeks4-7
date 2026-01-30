using Unity.Mathematics;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject spawningPrefab;
    public float waitDuration;
    private float waitprogress=0f;
    private float destroyprogress = 0f;
    public float destroyDuration;
    public float pacerspeed;
    public Color pacerColour;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        //EMPTY VECTOR3
        Vector3 originPosition = Vector3.zero;

        //EMPTY ROTATION
        Quaternion originRotation = Quaternion.identity;

       

        //SPAWNING AT THE POSITION OF THE SPAWNER (WITH THE SPAWNER'S ROTATION)
      //Instantiate(spawningPrefab, transform.position, transform.rotation);

        //SPAWNING AT THE ORIGIN
        //Instantiate(spawningPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        waitprogress += Time.deltaTime;
        if (waitprogress > waitDuration)
        {
            GameObject spawnedObject = Instantiate(spawningPrefab, transform.position, Quaternion.identity);
           pacer spawnedPacer= spawnedObject.GetComponent<pacer>();
           SpriteRenderer spawnedRenderer = spawnedObject.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = pacerColour;
            spawnedPacer.speed = pacerspeed;
            waitprogress = 0f;
            //Destroy(spawnedObject, destroyDuration);
        } 
       
       
    }
    public void inceasePacerSpeed()
    {
        pacerspeed++;
    }

}
