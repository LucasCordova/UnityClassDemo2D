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

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            move = 1f;
        }

        else if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            move = -1f;
        }

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            steer = 1f;
        }

        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            steer = -1f;
        }
        
        float moveAmount = move * currentSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
    }
}
