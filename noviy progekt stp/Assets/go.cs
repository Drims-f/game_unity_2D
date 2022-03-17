using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go : MonoBehaviour
{
    public LayerMask ground;
    public Vector2 playerVelocity = new Vector2(5, 8);
    private Rigidbody2D rigidBody2dComponent;
    private Collider2D collider2dComponent;
    private SpriteRenderer spriteRendererComponent;
    public Joystick joy;
    private bool buf_jump = true;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody2dComponent = gameObject.GetComponent<Rigidbody2D>();
        collider2dComponent = gameObject.GetComponent<Collider2D>();
        spriteRendererComponent = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdatePlayerPosition();
    }

    public void Jump()
    {
        if ( collider2dComponent.IsTouchingLayers(ground))
        {
            buf_jump = true;
            rigidBody2dComponent.velocity = new Vector2(rigidBody2dComponent.velocity.x, playerVelocity.y);
            
        }

    }

    private void UpdatePlayerPosition()
    {
        float horizonMove = joy.Horizontal;
        //float jump = Input.GetAxis("Jump");

        if (horizonMove < 0)
        {
            rigidBody2dComponent.velocity = new Vector2(-playerVelocity.x, rigidBody2dComponent.velocity.y);

            spriteRendererComponent.flipX = true;
        }

        else if (horizonMove > 0)
        {
            rigidBody2dComponent.velocity = new Vector2(+playerVelocity.x, rigidBody2dComponent.velocity.y);

            spriteRendererComponent.flipX = false;
        }

        else if(collider2dComponent.IsTouchingLayers(ground) && buf_jump == false)
        {
            rigidBody2dComponent.velocity = Vector2.zero;
        }

       /* if (jump > 0 && collider2dComponent.IsTouchingLayers(ground))
        {
            rigidBody2dComponent.velocity = new Vector2(rigidBody2dComponent.velocity.x, playerVelocity.y);
        }*/
    }
   
}
