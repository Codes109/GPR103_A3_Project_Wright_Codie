using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCollisionTrigger : MonoBehaviour
{
    public GameObject lanternRef;

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
        }
        else
        {
            lanternRef.GetComponent<Animation>().Play();
        }
        
    }
}
