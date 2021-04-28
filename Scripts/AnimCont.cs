/*=================================================================================================
 *AnimCont.cs
 *=================================================================================================
 *This is the Animator Controller script which sets the parameters for the player sprite animation.
 *
 *Version 1.0
 *
 *@SetAnimBool()
 *Sets animation parameters based on player input. 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCont : MonoBehaviour
{
    //Get the player Animator
    public Animator playerAnim;
        
        private void Update()
    {
        SetAnimBool();
    }

    void SetAnimBool()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            playerAnim.SetBool("run", true);
        }
        else
        {
            playerAnim.SetBool("run", false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            playerAnim.SetBool("attack", true);
            playerAnim.SetBool("canMove", false);
        }
        else
        {

            playerAnim.SetBool("attack", false);
            playerAnim.SetBool("canMove", true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            playerAnim.SetBool("block", true);
            playerAnim.SetBool("canMove", false);
        }
        else
        {

            playerAnim.SetBool("block", false);
            playerAnim.SetBool("canMove", true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            playerAnim.SetBool("roll", true);
        }
        else
        {

            playerAnim.SetBool("roll", false);
        }
    }
}
