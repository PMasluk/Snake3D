using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : Singleton<CubeSpawner>
{


    //private void Start()
    //{
    //    SpawnNewCube();
    //}

    //public void SpawnNewCube()
    //{
    //    Vector3 position = GetNewCubePosition();
    //    if (distance < 3)
    //    {
    //        SpawnNewCube();
    //    }
    //    else
    //    {
    //        Instantiate(cube, position, Quaternion.identity);
    //    }
    //}
    //private Vector3 GetNewCubePosition()
    //{
    //    Vector3 newCubePosition;

    //    newCubePosition = new Vector3(Random.Range(-24, 25), 3, Random.Range(-24, 25));

    //    foreach (GameObject obj in ObstacleManager.Instance.GetSpawnedObstacleList())
    //    {
    //        distance = Vector3.Distance(obj.transform.position, newCubePosition);

    //    }

    //    return newCubePosition;
    //}
}
