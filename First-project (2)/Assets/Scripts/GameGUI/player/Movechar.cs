using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movechar : MonoBehaviour
{
    public GameObject player;
    public float xf = 1.0f;
    public float yf = 1.0f;
    public float zf = 0.5f;
    Vector3 var = Vector3.zero;
    void Start()
    {

    }
    void Update()
    {
       
    }
    public void LeftDown()
    {
        Vector3 target_Left = new Vector3(player.transform.position.x - xf, player.transform.position.y, zf);
        player.transform.position = Vector3.MoveTowards(player.transform.position, target_Left, 1.08f);
    }
    public void RightDown()
    {
        Vector3 target_Right = new Vector3(player.transform.position.x + xf, player.transform.position.y, zf);
        player.transform.position = Vector3.MoveTowards(player.transform.position, target_Right, 1.08f);
    }
    public void upDown()
    {
        Vector3 target_Up = new Vector3(player.transform.position.x, player.transform.position.y + yf, zf);
        player.transform.position = Vector3.MoveTowards(player.transform.position, target_Up, 1.08f);
    }
    public void downDown()
    {
        Vector3 target_Down = new Vector3(player.transform.position.x, player.transform.position.y - yf, zf);
        player.transform.position = Vector3.MoveTowards(player.transform.position, target_Down, 1.08f);
    }
    /*private void Move_AniEvnt()
    {
        Vector3 target_Up = new Vector3(transform.position.x, transform.position.y + 2.0f, 0);
        Vector3 target_Down = new Vector3(transform.position.x, transform.position.y - 2.0f, 0);
        Vector3 target_Left = new Vector3(transform.position.x - 2.0f, transform.position.y, 0);
        Vector3 target_Right = new Vector3(transform.position.x + 2.0f, transform.position.y, 0);

        int ran = Random.Range(0, 4);

        switch (ran)
        {
            case 0:
                transform.position = Vector3.MoveTowards(transform.position, target_Up, 1.08f);
                break;
            case 1:
                transform.position = Vector3.MoveTowards(transform.position, target_Down, 1.08f);
                break;
            case 2:
                transform.position = Vector3.MoveTowards(transform.position, target_Left, 1.08f);
                //sprite.flipX = false;
                break;
            case 3:
                transform.position = Vector3.MoveTowards(transform.position, target_Right, 1.08f);
                //sprite.flipX = true;
                break;
            default:
                break;
        }
    }*/
}
