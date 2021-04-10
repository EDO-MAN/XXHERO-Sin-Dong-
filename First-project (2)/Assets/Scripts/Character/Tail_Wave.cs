using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail_Wave : MonoBehaviour
{
    [SerializeField]
    private GameObject tail_Wave;
    [SerializeField]
    private float speed;

    float y;
    float x;

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        if (tail_Wave.transform.position.y >= 4.5f)
        {
            Destroy(tail_Wave);
        }
    }
}
