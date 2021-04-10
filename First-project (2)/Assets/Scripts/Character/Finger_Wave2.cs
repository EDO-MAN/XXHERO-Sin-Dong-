using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finger_Wave2 : MonoBehaviour
{
    [SerializeField]
    private GameObject finger_Vertical;
    [SerializeField]
    private float speed;

    float y;
    float x;
    
    private void Update()
    {
        finger_Vertical.transform.position += Vector3.up * speed * Time.deltaTime; ;
        if (finger_Vertical.transform.position.y >= 5.4f)
        {
            Destroy(finger_Vertical);
        }
    }
}
