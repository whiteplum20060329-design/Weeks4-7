using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    // This script controls the game timer using a  slider.

  
    public Slider slider;
    public float Duration;
    public  float playtime = 0f;
    public healthtbar healthtbar;
    public Gamestart Gamestart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playtime += Time.deltaTime * 1;  // Duration = total time limit of the game.
                                         // playtime keeps increasing every frame using Time.deltaTime.
        slider.value = playtime; // The slider value is updated with playtime,
                                 // so the player can see the timer visually.
        if (playtime > Duration && healthtbar.health.value>0)
        // Gamestart is referenced so the game can return to the start screen
        // when time runs out.
        // When playtime is greater than Duration and the player is still alive,
        // the game will go back to the start screen.
        {
            Gamestart.notstart();
        }
           
    }
}
