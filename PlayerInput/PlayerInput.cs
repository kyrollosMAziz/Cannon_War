using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour 
{
    Touch touch;
    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].fingerId ==0)
        {
            UtilityHelper.sceneController.DrawPredictedProjectile();
        }
        if (Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Ended) 
        {
            UtilityHelper.sceneController.Shoot();
        }
    }
}
