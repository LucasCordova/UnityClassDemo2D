using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR.Haptics;

public class Cruise : MonoBehaviour
{
    [SerializeField] float currentSpeed = 5f;
    [SerializeField] float steerSpeed = 200f;

    [SerializeField] float boostSpeed = 10f;

    [SerializeField] float startingSpeed = 5f;

    [SerializeField] ParticleSystem particleSystem = default!;

    [SerializeField] TMP_Text boostText = default!;


    void Start()
    {
        boostText.text = "DSHADHOSADOIASDIHPASPIHDPIASD";
        // boostText = GetComponent<TMP_Text>();
        //boostText = FindAnyObjectByType< TMP_Text>();
    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        boostText.text = string.Empty;
        var emission = particleSystem.emission;
        emission.enabled = false;
        currentSpeed = startingSpeed;
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boost"))
        {
            boostText.text = "Boost!";

            var emission = particleSystem.emission;
            emission.enabled = true;
            
            currentSpeed = boostSpeed;
            Destroy(collision.gameObject);
        }
        else
        {
            currentSpeed = startingSpeed;
        }

    }

    void Update()
    {
        var time = DateTime.Now;

        var expireTime = time.AddSeconds(5);

        if (DateTime.Now > expireTime)
        {
            
        }

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
