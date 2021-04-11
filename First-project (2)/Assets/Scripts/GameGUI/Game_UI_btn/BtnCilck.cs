using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class BtnCilck : MonoBehaviour
{
    public Transform slots;
    public float term;
    int n = 0;

    public void ClickSkill()
    {
        GameObject clickBtn = EventSystem.current.currentSelectedGameObject;
        Instantiate(Resources.Load(clickBtn.name), slots);
    }
    // Update is called once per frame
    public void ClickPlay()
    {
        StartCoroutine("PlaySkill");
    }
    IEnumerator PlaySkill()
    {
        for (int i = 0; i < 3/*slots.childCount*/; i++)
        {
            slots.GetChild(i).SendMessage("SkillStart");
            yield return new WaitForSeconds(term);
            EnemyTurn();
        }
    }
    void EnemyTurn()
    {
        StartCoroutine(EnemyTurnCoroutine());
    } 
    IEnumerator EnemyTurnCoroutine()
    {
        Debug.Log("EnemyTurn");
        Debug.Log($"{n++}");
        yield return new WaitForSeconds(term);

    }
}
