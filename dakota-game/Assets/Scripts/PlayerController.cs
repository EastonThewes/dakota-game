using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Components
    public Rigidbody2D rb;
    public Animator animator;

    // Player
    public float walkSpeed = 4f;
    //float speedLimiter = 0.7f;
    public float inputHorizontal;
    public float inputVertical;
    Vector2 movement;
    
    

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
        
        
      movement.x = Input.GetAxisRaw("Horizontal");
      movement.y = Input.GetAxisRaw("Vertical");
      
      animator.SetFloat("horizontal", movement.x);
      animator.SetFloat("vertical", movement.y);
      animator.SetFloat("speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        
        
            
            rb.MovePosition(rb.position + movement * walkSpeed * Time.fixedDeltaTime);
        
    }


}   

