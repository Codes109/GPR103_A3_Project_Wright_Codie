/*=================================================================================================
 *EndGameTrigger.cs
 *=================================================================================================
 *Used to transition the scene to the title screen upon game completion. 
 *
 *Version 1.0
 *
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))//Will only transistion scene if collision occurs with a GameObject tagged 'Player'.
        {
            SceneManager.LoadScene(5);
        }
    }
}
