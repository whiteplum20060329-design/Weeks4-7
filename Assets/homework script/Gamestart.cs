using UnityEngine;

public class Gamestart : MonoBehaviour
{
    // This script controls the game state: start screen and gameplay mode.
   
    // All main game objects are referenced here so they can be shown or hidden.
   
  public GameObject cat;
 
    public GameObject start;
    public GameObject slider;
    public GameObject shoot;
    public GameObject Health;
    public healthtbar healthtbar;
    public GameObject time;
    public timer timer;
    public GameObject rock;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        notstart();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void notstart()
    {
        // In Start(), the game is set to the "not started" state.
       
        // notstart() hides all gameplay objects and shows the start screen.
        cat.SetActive(false);
     
        start.SetActive(true);
        slider.SetActive(false);
        shoot.SetActive(false);
        Health.SetActive(false);
        time.SetActive(false);
        rock.SetActive(false);
    }
    public void startgame()
    {
        // startgame() shows all gameplay objects and hides the start screen.


        // It also resets the player's HP and the timer so the game can restart cleanly.
        cat.SetActive(true);
      
        start.SetActive(false);
        slider.SetActive(true);
        shoot.SetActive(true);
        Health.SetActive(true);
        healthtbar.health.value = 10;
        time.SetActive(true);
        rock.SetActive(true);
        timer.playtime = 0;

    }
}
