using System.Collections;
using UnityEngine;

public class WallBuilder : MonoBehaviour
{
    [SerializeField]
    private GameObject primitivePrototypeObject;

    private Transform wall;

    void Start()
    {
        if (GameObject.Find("WallHolder")) 
        {
            wall = GameObject.Find("WallHolder").transform;
        }
        BuildWall();
    }
    void Update()
    {
        //test
        if (Input.GetKeyUp(KeyCode.Space))
        {
            BuildWall();
        }
        //test
    }
    public void BuildWall(Transform wallPosition = null)
    {
        Vector3 newWallPos = Vector3.zero;
        GameObject newWall = new GameObject();
        GameObject oldWall ;

        if (wallPosition)
        {
            newWallPos = wallPosition.position;
        }
        else
        {
            newWallPos = wall.position;
        }

        newWall.transform.position = newWallPos;
        newWall.name = "WallHolder";
        oldWall = wall.gameObject;
        Destroy(oldWall);
        wall = newWall.transform;

        for (int i = 0; i < 6; i++)
        {
            for(int k =0; )
            for (int j = 0; j < 6; j++)
            {
                GameObject go = Instantiate(primitivePrototypeObject);
                go.transform.position = new Vector3(i, j, 0);
                go.transform.parent = newWall.transform;
            }
        }
    }
    public void AddToWall(Transform objectToAddToWall) 
    {
        objectToAddToWall.transform.parent = wall;
    }
}
