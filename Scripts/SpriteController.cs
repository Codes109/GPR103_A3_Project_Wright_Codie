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

    private void FixedUpdate()//Perform physics on player rigidbody in fixedUpdate.
    {
        playerFrame.velocity = moveDir * speed;
    }

    void KnightMovement()
    {
   
        float xMovement = 0f;
        float yMovement = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            yMovement = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            xMovement = -1f;
            transform.localScale = new Vector2(-1, 1);//Change sprite direction.
        }
        if (Input.GetKey(KeyCode.S))
        {
            yMovement = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            xMovement = 1f;
            transform.localScale = new Vector2(1, 1);
        }

        moveDir = new Vector3(xMovement, yMovement).normalized;

    }
    //The VelocityState function is used to determine the state in which the player is in based on its velocity.
   

    //Calls function whenever object interacts with a trigger.
   

    private void Attack()//In development
    {

    }
    
}
