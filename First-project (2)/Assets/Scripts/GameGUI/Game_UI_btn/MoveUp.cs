using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveUp : MonoBehaviour
{
    public GameObject player;
    Vector3 var = Vector3.zero;
    public void SkillStart()
    {
        Debug.Log("PlayerTrun");
        //이부분이 오류나는거 같아요. 전체적인 이동 함수에서
        
        StartCoroutine(Move_Up());
    }
    IEnumerator Move_Up()
    {
        //Debug.Log("moveUp");
        //Vector3 target_Up = new Vector3(player.transform.position.x, player.transform.position.y + 1.0f, 0.5f);
        //player.transform.position = Vector3.MoveTowards(player.transform.position, target_Up, 1.08f);
        player.transform.DOMove(Vector2.up, 2f);
        yield return null;
    }
}
