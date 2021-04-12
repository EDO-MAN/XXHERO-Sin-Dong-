using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveLeft : MonoBehaviour
{
    public GameObject player;

    public void SkillStart()
    {
        Debug.Log("플레이어턴.왼쪽");
        StartCoroutine(Move_Left());
    }

    IEnumerator Move_Left()
    {
        player.transform.DOMove(Vector2.left, 2f);
        print("MoveLeft");
        yield return null;
    }
}
