using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : Singleton<ObstacleManager>
{
    [SerializeField]
    private List<GameObject> obstacleList = new List<GameObject>();
    [SerializeField]
    private List<GameObject> spawnedObstacleList = new List<GameObject>();
    [SerializeField]
    private int maxSpawnAmount;

    public void Awake()
    {
        for (int i = 0; i < maxSpawnAmount; i++)
        {
            GameObject obj = Instantiate(obstacleList[Random.Range(0, 3)], NewObstaclePosition(), Quaternion.Euler(0, Random.Range(0, 4) * 90, 0));
            spawnedObstacleList.Add(obj);
        }
    }

    private Vector3 NewObstaclePosition()
    {
        float positionX = Random.Range(-22, 23);
        float positionZ = Random.Range(-22, 23);

        while (positionX > -3 && positionX < 3)
        {
            positionX = Random.Range(-22, 23);
        }
        while (positionZ > -3 && positionZ < 3)
        {
            positionZ = Random.Range(-22, 23);
        }

        Vector3 newObstaclePosition = new Vector3(positionX, 3, positionZ);

        return newObstaclePosition;
    }

    public List<GameObject>GetSpawnedObstacleList()
    {
        return spawnedObstacleList;
    }

}
