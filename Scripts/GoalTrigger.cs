using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    //Declare variables

    //public bool to check trigger activation. Public access for TriggerDoor script.
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
