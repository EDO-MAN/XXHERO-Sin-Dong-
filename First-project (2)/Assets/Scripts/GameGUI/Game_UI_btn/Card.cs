using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using DG.Tweening;


public class Card : MonoBehaviour
{
    public virtual void UseCard(GameObject player)
    {
        // 디폴트
        Console.WriteLine("디폴트");
    }
}
public class UpCard : Card
{
    public override void UseCard(GameObject player)
    {
        player.transform.DOMove(Vector2.up, 1.5f);
    }
}
public class DownCard : Card
{
    public override void UseCard(GameObject player)
    {
        player.transform.DOMove(Vector2.down, 1.5f);
    }
}
public class LeftCard : Card
{
    public override void UseCard(GameObject player)
    {
        player.transform.DOMove(Vector2.left, 1.5f);
    }
}

public class RightCard : Card
{
    public override void UseCard(GameObject player)
    {
        player.transform.DOMove(Vector2.right, 1.5f);
    }
}
