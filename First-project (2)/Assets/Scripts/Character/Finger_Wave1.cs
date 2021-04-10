using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finger_Wave1 : MonoBehaviour
{
    [SerializeField]
    private GameObject finger_Horizontal;
    [SerializeField]
    private float speed;

    float x;
    float y;
    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position -= Vector3.right * speed * Time.deltaTime;
        if (finger_Horizontal.transform.position.x <= -7.0f)
        {
            Destroy(finger_Horizontal);
        }
    }
}
