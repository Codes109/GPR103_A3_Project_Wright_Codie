/*=================================================================================================
 *CameraController.cs
 *=================================================================================================
 *This is the script that sets the camera size to match the screen size.
 *
 *Version 1.0
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Declare variable for background sprite. Used for getting desired game view size.
    public SpriteRenderer background;

    void Start()
    {
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float targetRatio = background.bounds.size.x / background.bounds.size.y;

        //Compares the ratios of the screen and desired game size. Sets the camera size to correct ratio to play game.
        if (screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = background.bounds.size.y / 2;
        }
        else
        {
            float differenceInSize = targetRatio / screenRatio;
            Camera.main.orthographicSize = background.bounds.size.y / 2 * differenceInSize;
        }
    }
}
