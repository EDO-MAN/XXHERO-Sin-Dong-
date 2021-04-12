using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveDown : MonoBehaviour
{
    public GameObject player;
    //Vector3 var = Vector3.zero;
    public void SkillStart()
    {
        Debug.Log("플레이어턴.밑");
        StartCoroutine(Move_Down());
    }
    IEnumerator Move_Down()
    {
        player.transform.DOMove(Vector2.down, 2f);
        print("MoveDown");
        yield return null;
    }
}
