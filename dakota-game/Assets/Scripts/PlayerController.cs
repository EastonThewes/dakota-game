using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Components
    Rigidbody2D rb;

    // Player
    float walkSpeed = 4f;
    //float speedLimiter = 0.7f;
    float inputHorizontal;
    float inputVertical;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      inputHorizontal = Input.GetAxisRaw("Horizontal");
      inputVertical = Input.GetAxisRaw("Vertical");
      
    }

    void FixedUpdate()
    {
        if (inputHorizontal != 0 || inputVertical != 0)
        {
            Debug.Log("test");
            rb.velocity = new Vector2(inputHorizontal * walkSpeed, inputVertical * walkSpeed);
        }
    }

}   

