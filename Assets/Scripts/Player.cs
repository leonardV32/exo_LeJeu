using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxspeed;

    [SerializeField] private Transform Spawnpoint;

    [SerializeField] private Transform raycastTransform;
    
    //[SerializeField]

    private bool canFlip;

    private float direction;

    private SpriteRenderer spriterenderer;

   

    private Rigidbody2D rb2D;

    private Controls controls;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Main.MoveLR.performed += MoveLROnperformed;
        controls.Main.MoveLR.canceled += MoveLROncanceled;
        controls.Main.GravitySwap.performed += GravitySwapOnperformed;

    }

    private void MoveLROnperformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<float>();
        if (direction > 0)
        {
            spriterenderer.flipX = false;
        }
        else
        {
            spriterenderer.flipX = true;
        }
    }

    private void MoveLROncanceled(InputAction.CallbackContext obj)
    {
        direction = 0;

    }
    private void GravitySwapOnperformed(InputAction.CallbackContext obj)
    {   
        if (canFlip == true)
        {
            rb2D.gravityScale *= -1; // rb2D.gravityScale = rb2D.gravityScale * -1
            spriterenderer.flipY = rb2D.gravityScale < 0;

            
        }
       
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        canFlip = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        var horizontalSpeed = Mathf.Abs(rb2D.velocity.x);
        if (horizontalSpeed < maxspeed)
        {
            rb2D.AddForce(new Vector2(speed * direction, 0));
        }

    
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.contacts[0].normal.x == 0) // plafond ( 0 , -1) sol ( 0 , 1 )
        {
            canFlip = true;
            
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canFlip = false;
    }

    private void OnTriggerEnter2D(Collider2D colliderTriggered)
    {

        rb2D.transform.position = Spawnpoint.position;
        spriterenderer.flipY = false;
        rb2D.gravityScale = 1;
    }
}
