using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveUp : MonoBehaviour
{
    public GameObject player;

    public void SkillStart()
    {
        Debug.Log("플레이어턴.위");
        StartCoroutine(Move_Up());
    }

    IEnumerator Move_Up()
    {
        player.transform.DOMove(Vector2.up, 2f);
        print("MoveUp");
        yield return null;
    }
}
