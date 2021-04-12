using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveRight : MonoBehaviour
{
    public GameObject player;
    public void SkillStart()
    {
        Debug.Log("플레이어턴.오른쪽");
        StartCoroutine(Move_Right());
    }
    IEnumerator Move_Right()
    {
        player.transform.DOMove(Vector2.right, 2f);
        print("MoveRight");
        yield return null;
    }
}
