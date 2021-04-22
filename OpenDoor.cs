using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public SpriteRenderer doorSprite;
    public BoxCollider2D exitDoorCollider;
    public Sprite doorSprites;
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
            doorSprite.sprite = doorSprites;
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
