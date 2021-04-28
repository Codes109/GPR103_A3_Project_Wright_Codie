/*=================================================================================================
 *StartGameButton.cs
 *=================================================================================================
 *Attached to Button on Title scene to transition to the next scene upon click. 
 *
 *Version 1.0
 *
 *@StartGame()
 *Transitions to scene with index 1.
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

}
