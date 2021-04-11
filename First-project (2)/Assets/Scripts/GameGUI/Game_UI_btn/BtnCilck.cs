using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using DG.Tweening;

public class BtnCilck : MonoBehaviour
{
    public Transform slots;
    public GameObject player;
    public float term;
    int n = 0;

    public void ClickSkill()
    {
        GameObject clickBtn = EventSystem.current.currentSelectedGameObject;
        Instantiate(Resources.Load(clickBtn.name), slots);
    }
    public void ClickPlay()
    {
        for (int i = 0; i < slots.childCount; i++) 
        {
            player.transform.position = slots.GetChild(i).GetComponent<Card>().UseCard(player);
        }
    }

    //public void ClickPlay()
    //{
    //    StartCoroutine("PlaySkill");
    //}
    //IEnumerator PlaySkill()
    //{
    //    for (int i = 0; i < 3/*slots.childCount*/; i++)
    //    {
    //        //slots.GetChild(i).SendMessage("SkillStart");
    //        player.transform.position = slots.GetChild(i).GetComponent<MoveCard>.move;
    //        yield return new WaitForSeconds(term);
    //        EnemyTurn();
    //    }
    //}
    void EnemyTurn()
    {
        StartCoroutine(EnemyTurnCoroutine());
    } 
    IEnumerator EnemyTurnCoroutine()
    {
        Debug.Log("EnemyTurn");
        yield return new WaitForSeconds(term);

    }
}
