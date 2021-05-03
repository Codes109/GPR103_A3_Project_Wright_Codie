/*=================================================================================================
 *LoadingMoveBox.cs
 *=================================================================================================
 *Attached to Box GameObject on the loading screen scene. Used to control box movement and scene transition. 
 *
 *Version 1.0
 *
 *@PushBox()
 *Pushes GameObject script is attached to.
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingMoveBox : MonoBehaviour
{
    //Declare a vector2 for pushing box at steady rate.
    Vector2 pushVector;
    public int index;

    private void Start()
    {
     pushVector = new Vector2(4, 0);
    }

    //Used FixedUpdate due to physics manipulation.
    void FixedUpdate()
    {
        PushBox();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadSceneAsync(index); //Change to the next scene via scene index. Intended for re-use.
    }

    //Use the Rigidbody component velocity to move the Box GameObject.
    void PushBox()
    {
        GetComponent<Rigidbody2D>().velocity = pushVector;
    }
}
