using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    public Rigidbody2D playerFrame = new Rigidbody2D();
    public float speed = 1;
    public Animator playerAnim;


    private Vector3 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        playerFrame = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            KnightMovement();
    }

    private void FixedUpdate()
    {
        playerFrame.velocity = moveDir * speed;
    }

    void KnightMovement()
    {
        /*//Getting the Horizontal and Vertical axis inputs. This is controlled by the unity project settings.
        float hDirection = Input.GetAxis("Horizontal");
        float vDirection = Input.GetAxis("Vertical");

        if (hDirection < 0)
        {
            playerFrame.velocity = new Vector2(-speed, 0);
            transform.localScale = new Vector2(-1, 1);
        }

        else if (hDirection > 0)
        {
            playerFrame.velocity = new Vector2(speed, 0);
            transform.localScale = new Vector2(1, 1);
        }

        else if (vDirection < 0)
        {
            playerFrame.velocity = new Vector2(0,-speed);

        }

        else if (vDirection > 0)
        {
            playerFrame.velocity = new Vector2(0, speed);
        }
        */
        float movex = 0f;
        float movey = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            movey = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movex = -1f;
            transform.localScale = new Vector2(-1, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movey = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movex = 1f;
            transform.localScale = new Vector2(1, 1);
        }

        moveDir = new Vector3(movex, movey).normalized;

    }
    //The VelocityState function is used to determine the state in which the player is in based on its velocity.
   

    //Calls function whenever object interacts with a trigger.
   

    private void Attack()
    {

    }
    
}
