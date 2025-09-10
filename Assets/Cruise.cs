using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR.Haptics;

public class Cruise : MonoBehaviour
{
    [SerializeField] float currentSpeed = 5f;
    [SerializeField] float steerSpeed = 200f;

    void Start()
    {
        
    }


    void Update()
    {
        float move = 0f;
        float steer = 0f;

        Debug.Log("Crusing...");

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            Debug.Log("Forward movement");
            move = 1f;
        }
        else if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            Debug.Log("Backward movement");
            move = -1;
        }
        else if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            Debug.Log("Left movement");
            steer = -1f;

        }
        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            Debug.Log("Right movement");

            steer = -1f;
        }

        float moveAmount = move * Time.deltaTime * currentSpeed;
        float steerAmount = steer * Time.deltaTime * steerSpeed;

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
        
        
    }
}
