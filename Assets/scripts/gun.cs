using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class gun : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //I tried to make the object rotate to follow the mouse. I wanted the object
        //    to always face the mouse position.But it did not work the way I expected.
        //    I think I still don¡¯t fully understand how rotation works in Unity.
        //    I will try more methods and watch the tutorial again to fix it. 
        //    This helped me learn that rotation is harder than moving an object

        //codegym 1
        Vector3 MousePos = Mouse.current.position.ReadValue();//get the pos of the mouse on the screen first.

        Vector3 worldMouse = Camera.main.ScreenToWorldPoint(MousePos);



        transform.eulerAngles +=transform.forward * MousePos.z;

     





    }
}
