using UnityEngine;
using UnityEngine.UI;

public class sushicolok : MonoBehaviour
{
    public Slider sushislider;
    public float clockDuration;
    private float timeWaiting = 0f;

    public GameObject warperObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      timeWaiting += Time.deltaTime*1;
        sushislider.value = timeWaiting;
        if (timeWaiting>clockDuration)
        {
            timeWaiting = 0f;
            Debug.Log("Time is up");

            bool shouldturnon= !warperObject.activeInHierarchy;
            bool shouldturnoff = warperObject.activeInHierarchy;
            if (shouldturnon == true)
            {
                Debug.Log("on");
                warperObject.SetActive(true);
            }

  
            if (shouldturnoff)
            {
                Debug.Log("off");
                warperObject.SetActive(false);
            }



        }
    }
}
