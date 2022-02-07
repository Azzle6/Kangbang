using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ELC_Move : MonoBehaviour
{
    public float JumpForce;
    public float HorizontalForce;
    public int movingSide = 1;
    public SpriteRenderer sr;
    private Rigidbody2D rb;
    private AudioManager audioManager;
    private SkinManager skinManager;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        audioManager = AudioManager.instance;
        skinManager = SkinManager.instance;
        sr.sprite = skinManager.sprite;
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
        audioManager.Play("Jump");
    }

    public void SwitchSide()
    {
        movingSide = -movingSide;
    }
}
