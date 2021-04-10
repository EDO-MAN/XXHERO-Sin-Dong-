using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearEnergy : MonoBehaviour
{
    [SerializeField]
    private GameObject spear;
    [SerializeField]
    private float speed;

    float y;
    float x;
   

    private void Update()
    {
        transform.position -= Vector3.right *  speed * Time.deltaTime;
        if(spear.transform.position.x <= -5.5f)
        {
            Destroy(spear);
        }
    }
}
