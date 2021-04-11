using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveLft : MonoBehaviour
{
    public GameObject player;

    Vector3 var = Vector3.zero;
    public void SkillStart()
    {
        Debug.Log("PlayerTrun");
        //이부분이 오류나는거 같아요. 전체적인 이동 함수에서
        StartCoroutine(Move_Left());
    }
    IEnumerator Move_Left()
    {
        player.transform.DOMove(Vector2.left, 2f);
        yield return null;
    }
}
