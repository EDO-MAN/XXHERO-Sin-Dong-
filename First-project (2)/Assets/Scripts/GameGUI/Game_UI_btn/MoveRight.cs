﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveRight : MonoBehaviour
{
    public GameObject player;
    //Vector3 var = Vector3.zero;
    public void SkillStart()
    {
        Debug.Log("PlayerTrun");
        StartCoroutine(Move_Right());

    }
    IEnumerator Move_Right()
    {
        player.transform.DOMove(Vector2.right, 2f);
        print("MoveRight");
        yield return null;
    }
}
