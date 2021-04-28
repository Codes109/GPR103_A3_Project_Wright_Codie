/*=================================================================================================
 *GoalTrigger.cs
 *=================================================================================================
 *Attached to GoalObjects in each level. Allows for a tag to be entered in the Unity editor. Checks for correct tag upon tirgger and sets variable to true.
 *
 *
 *Version 1.0
 *
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    //Declare variables

    //public bool to check trigger activation. Public access for OpenDoor.cs.
    public bool isGoalTriggered;
    //public string for box tags.
    public string boxTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(boxTag) == true)
        {
            isGoalTriggered = true;
        }
        
    }
}
