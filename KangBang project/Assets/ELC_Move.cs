using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ELC_Move : MonoBehaviour
{
    public float JumpForce;
    public float HorizontalForce;
    private int movingSide = 1;
    private Rigidbody2D rb;
    
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        Vector2 newVelo = new Vector2(HorizontalForce * movingSide, rb.velocity.y);

        rb.velocity = newVelo;
        
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x,JumpForce);
    }

    public void SwitchSide()
    {
        movingSide = -movingSide;
    }
}
