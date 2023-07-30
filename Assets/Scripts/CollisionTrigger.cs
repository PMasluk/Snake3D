using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    private float distance = 0;
    private void Start()
    {
        SpawnNewCube();
    }
    private void OnCollisionEnter(Collision collision)
    {
        SnakeMover.Instance.AddBodyPart();
        SpawnNewCube();
        ScoreManager.Instance.AddPoint();
    }

    public void SpawnNewCube()
    {
        Vector3 position = GetNewCubePosition();
        if (distance < 3)
        {
            SpawnNewCube();
        }
        else
        {
            transform.position = position;
        }
    }
    private Vector3 GetNewCubePosition()
    {
        Vector3 newCubePosition;

        newCubePosition = new Vector3(Random.Range(-21, 22), 3, Random.Range(-24, 25));

        List<GameObject> list = ObstacleManager.Instance.GetSpawnedObstacleList();

        distance = 100;

        for (int i = 0; i < list.Count; i++)
        {
            GameObject obj = list[i];
            float distance = Vector3.Distance(obj.transform.position, newCubePosition);

            if (distance < this.distance)
            {
                this.distance = distance;
            }
        }

        return newCubePosition;
    }

}
