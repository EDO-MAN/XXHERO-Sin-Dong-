using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveDown : MonoBehaviour
{
    public GameObject player;
    Vector3 var = Vector3.zero;
    public void SkillStart()
    {
        //Vector3 target_Down = new Vector3(player.transform.position.x, player.transform.position.y - 1.0f, 0.5f);
        //player.transform.position = Vector3.MoveTowards(player.transform.position, target_Down, 1.08f);
        //이부분이 오류나는거 같아요. 전체적인 이동 함수에서
        StartCoroutine(Move_Down());
        
    }
    IEnumerator Move_Down()
    {
        player.transform.DOMove(Vector2.down, 2f);
        print("MoveDown");
        yield return null;
    }
}
