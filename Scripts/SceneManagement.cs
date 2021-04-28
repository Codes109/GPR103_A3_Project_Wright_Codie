/*=================================================================================================
 *SceneManagement.cs
 *=================================================================================================
 *Allows for transition to new scene indicated by public int in Unity editor. Attached to end of level colliders. 
 *
 *Version 1.0
 *
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public int index;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(index);
        }
    }
}
