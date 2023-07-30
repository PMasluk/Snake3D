using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMover : Singleton<SnakeMover>
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float steerSpeed;
    [SerializeField]
    private GameObject bodyPart;
    [SerializeField]
    private int gap;

    private List<GameObject> bodyParts = new List<GameObject>();
    private List<Vector3> positionHistory = new List<Vector3>();

    private void Awake()
    {
        AddBodyPart();
        Time.timeScale = 0;
    }
    private void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;


        float steerDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerDirection * steerSpeed * Time.deltaTime);

        positionHistory.Insert(0, transform.position);
        int index = 0;
        foreach (var body in bodyParts)
        {
            Vector3 point = positionHistory[Mathf.Min(index * gap, positionHistory.Count-1)];
            body.transform.position = point;
            index++;
        }
    }
    public void AddBodyPart()
    {
        GameObject body = Instantiate(bodyPart);
        bodyParts.Add(body);
    }
}
