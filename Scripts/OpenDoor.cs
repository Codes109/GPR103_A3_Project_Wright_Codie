/*=================================================================================================
 *OpenDoor.cs
 *=================================================================================================
 *Attached to ExitDoor GameObjects in each level.
 *Checks for all true instances of goals array. If all goals are true exitDoor GameObject sprite is changed and collider is disabled. 
 *
 *Version 1.0
 *
 *@AreGoalsMet()
 *For loop checking for true isGoalTriggered boolean in script attached to each GameObject in goals array.
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public SpriteRenderer exitDoorSpriteRend;
    public BoxCollider2D exitDoorCollider;
    public Sprite openDoorSprite;
    public GameObject[] goals;
    



    //When a trigger happens show the open door sprite and disable the box collider attached.
    /*  private void OnTriggerEnter2D(Collider2D collision)
    {
        doorSprite.sprite = doorSprites;
        exitDoorCollider.enabled = false;
    }*/


    private void Update()
    {
        if (AreGoalsMet() == true)
        {
            exitDoorSpriteRend.sprite = openDoorSprite;
            exitDoorCollider.enabled = false;
        }   
    }

    private bool AreGoalsMet()
    {
        for (int i = 0; i < goals.Length; i++)
        {
            if (goals[i].GetComponent<GoalTrigger>().isGoalTriggered == false)
            {
                return false;
            }
            
        }
        return true;
    }
}
