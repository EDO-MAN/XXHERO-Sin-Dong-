using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveLft : MonoBehaviour
{
    public GameObject player;

    //Vector3 var = Vector3.zero;
    public void SkillStart()
    {
        Debug.Log("PlayerTrun");
        StartCoroutine(Move_Left());
    }
    IEnumerator Move_Left()
    {
        player.transform.DOMove(Vector2.left, 2f);
        print("MoveLeft");
        yield return null;
    }
}
