using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // This public function is called when the button is clicked.
    // Each time it is called, a new prefab is created in the scene.
    public void Spawn()
    {
        // Create a random position 
        Vector3 randomPos = Vector2.one * Random.insideUnitCircle * 10;
        

        // Instantiate creates a new instance of the prefab.
       
        Instantiate(prefab, randomPos, Quaternion.identity);
    }
    
}
   


