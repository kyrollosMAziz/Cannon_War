using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    ShootingController catapultController;

    [SerializeField]
    PlayerInput playerInput;

    [SerializeField]
    WallBuilder wallBuilder;

    private void Awake()
    {
        UtilityHelper.sceneController = this;
    }
    private void Start()
    {
        wallBuilder = GameObject.FindObjectOfType<WallBuilder>();
        catapultController = GameObject.FindObjectOfType<ShootingController>();
        playerInput = GameObject.FindObjectOfType<PlayerInput>();
    }
    public void DrawPredictedProjectile() 
    {
        catapultController.PredictedProjectile();
    }
    public void Shoot() 
    {
        var projectile = catapultController.Shoot();
        wallBuilder.AddToWall(projectile.transform);
    }

}
