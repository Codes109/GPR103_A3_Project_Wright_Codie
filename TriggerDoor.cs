using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    public SpriteRenderer doorSprite;
    public BoxCollider2D exitDoorCollider;
    public Sprite doorSprites;
    

    //When a trigger happens show the open door sprite and disable the box collider attached.
      private void OnTriggerEnter2D(Collider2D collision)
    {
        doorSprite.sprite = doorSprites;
        exitDoorCollider.enabled = false;
    }

}
