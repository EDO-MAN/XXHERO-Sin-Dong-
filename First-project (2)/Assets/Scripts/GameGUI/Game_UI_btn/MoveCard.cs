using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using DG.Tweening;


public class Card : MonoBehaviour
{
    public virtual void UseCard()
    {
        // 디폴트
        Console.WriteLine("디폴트");
    }
}
class UpCard : Card
{
    public override void UseCard()
    {

    }
}
class DownCard : Card
{
    public override void UseCard()
    {

    }
}
class LeftCard : Card
{
    public override void UseCard()
    {

    }
}
class RightCard : Card
{
    public override void UseCard()
    {

    }
}
class AttackCard : Card
{
    public override void UseCard()
    {

    }
}
class Program
{
    public static void Main(string[] args)
    {

        Card[] cardCase = new Card[]
        {
            new LeftCard(),
            new UpCard(),
            new RightCard(),
            new DownCard(),
            new AttackCard(),
            new LeftCard(),
        };
        for (int i = 0; i < cardCase.Length; i++)
        {
            cardCase[i].UseCard();
        }
    }
}


