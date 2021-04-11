﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveUp : MonoBehaviour
{
    public GameObject player;
    //Vector3 var = Vector3.zero;
    public Vector2 move = Vector2.up;
    public void SkillStart()
    {
        Debug.Log("PlayerTrun");
        StartCoroutine(Move_Up(player.transform));
    }
    IEnumerator Move_Up(Transform tr)
    {
        //Debug.Log("moveUp");
        //Vector3 target_Up = new Vector3(player.transform.position.x, player.transform.position.y + 1.0f, 0.5f);
        //player.transform.position = Vector3.MoveTowards(player.transform.position, target_Up, 1.08f);
        tr.transform.DOMove(move, 2f);
        print("MoveUp");
        yield return null;
    }
}
