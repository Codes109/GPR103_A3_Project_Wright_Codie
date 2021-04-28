/*=================================================================================================
 *QuitGameButton.cs
 *=================================================================================================
 *Attached to Button on Title scene to exit the application upon click. 
 *
 *Version 1.0
 *
 *@QuitGame()
 *Closes the application.
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameButton : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
}
