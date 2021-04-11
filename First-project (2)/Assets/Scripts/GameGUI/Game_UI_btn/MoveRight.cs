using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveRight : MonoBehaviour
{
    public GameObject player;
    Vector3 var = Vector3.zero;
    public void SkillStart()
    {
        Debug.Log("PlayerTrun");
        //이부분이 오류나는거 같아요. 전체적인 이동 함수에서
        player.transform.DOMove(Vector2.right, 2f);

    }
}
