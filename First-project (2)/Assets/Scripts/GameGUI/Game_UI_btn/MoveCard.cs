using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using DG.Tweening;


public class Card : MonoBehaviour
{
    public virtual void UseCard(Transform playerPos)
    {
        // 디폴트
        Console.WriteLine("디폴트");
    }
}
class UpCard : Card
{
    public override void UseCard(Transform playerPos)
    {
        playerPos.transform.DOMove(Vector2.up, 2f);
    }
}
class DownCard : Card
{
    public override void UseCard(Transform playerPos)
    {
        playerPos.transform.DOMove(Vector2.down, 2f);
    }
}
class LeftCard : Card
{
    public override void UseCard(Transform playerPos)
    {
        playerPos.transform.DOMove(Vector2.left, 2f);
    }
}

class RightCard : Card
{
    public override void UseCard(Transform playerPos)
    {
        playerPos.transform.DOMove(Vector2.right, 2f);
    }
}

class Program
{
    public static Transform playerPos;
    public static void Main(string[] args)
    {

        Card[] cardCase = new Card[]
        {
            new LeftCard(),
            new UpCard(),
            new RightCard(),
            new DownCard(),
            new LeftCard(),
        };
        for (int i = 0; i < cardCase.Length; i++)
        {
            cardCase[i].UseCard(playerPos);
        }
    }
}


