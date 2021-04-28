/*=================================================================================================
 *Retry.cs
 *=================================================================================================
 *Attached to Lantern GameObject. Upon collision with GameObject tagged 'Player' gets active scene index and reloads scene. 
 *
 *Version 1.0
 *
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
