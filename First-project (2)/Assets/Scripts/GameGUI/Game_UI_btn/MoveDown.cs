using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public GameObject player;
    Vector3 var = Vector3.zero;
    public void SkillStart()
    {
        Vector3 target_Down = new Vector3(player.transform.position.x, player.transform.position.y - 1.0f, 0.5f);
        player.transform.position = Vector3.MoveTowards(player.transform.position, target_Down, 1.08f);
        print("MoveDown");
    }
}
