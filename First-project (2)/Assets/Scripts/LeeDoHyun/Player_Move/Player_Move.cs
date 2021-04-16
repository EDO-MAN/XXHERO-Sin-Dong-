using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player_Move : MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;
    float speed = 20.0f;

    Rigidbody2D rigid;
    SpriteRenderer sprite;
    Animator anim;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    private float curTime;
    public float attack_coolTime = 0.5f;
    public Transform pos;
    public Vector2 boxSize;
    void Update()
    {
        //'Z' Attack
        if (curTime <= 0)
        {
            //Attack
            if(Input.GetKey(KeyCode.Z))
            {
                Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(pos.position,boxSize, 0);
                foreach  (Collider2D collider in collider2Ds)
                {
                    Debug.Log(collider.tag);
                }

                anim.SetTrigger("doAttack");
                curTime = attack_coolTime;
            }
        }
        else
        {
            curTime -= Time.deltaTime;
        }


        //Jump
        if (Input.GetButtonDown("Jump") /*&& !anim.GetBool("isJumping")*/)
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            
        }

        //Stop speed
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.x * 0.5f, rigid.velocity.y);
        }
        //DirectionX 
        if (Input.GetButton("Horizontal"))
        {
            sprite.flipX = Input.GetAxisRaw("Horizontal") == -1;
        }
        if (Mathf.Abs(rigid.velocity.x) < 0.1f)
            anim.SetBool("isMove", false);
        else
            anim.SetBool("isMove", true);
    }

    void FixedUpdate()
    {
        //Move By Key Control
        float h = Input.GetAxis("Horizontal");

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed)//Right Max Speed
        {
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        }
        else if (rigid.velocity.x < maxSpeed * (-1))//Left Max Speed
        {
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(pos.position, boxSize);
    }
}
