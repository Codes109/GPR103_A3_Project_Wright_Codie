/*=================================================================================================
 *ResetCollisionTrigger.cs
 *=================================================================================================
 *Attached to all Box GameObjects. Used to play the flashing animation on Lantern reset GameObject. Will trigger if any Box GameObjects collide with other GameObjects excluding the player collider. 
 *
 *Version 1.0
 *
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCollisionTrigger : MonoBehaviour
{
    //Get the lantern GameObject for manipulating the animation component.
    public GameObject lanternRef;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))//Will do nothing if the other collider is attached to a GameObject with the 'Player' tag.
        {
        }
        else
        {
            lanternRef.GetComponent<Animation>().Play();
        }
        
    }
}
