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
        player.transform.DOMove(Vector2.left, 2f);
    }
}
