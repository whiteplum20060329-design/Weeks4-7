using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class wapper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool shouldwarp = Mouse.current.leftButton.wasPressedThisFrame && 
            !EventSystem.current.IsPointerOverGameObject();
        if (shouldwarp == true)
        {
            Vector3 mouse = Mouse.current.position.ReadValue();

            transform.position = mouse;

        }
    }
}
