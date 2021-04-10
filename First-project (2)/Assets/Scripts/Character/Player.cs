using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private SpriteRenderer sprite;
    private Animator anim;

    [SerializeField]
    private LayerMask layerMask;
    [SerializeField]
    private LayerMask _layerMask;

    public float speed;

    private Vector3 vector;

    public float walkCount;
    private float currentWalkCount;
    public bool canMove = true;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    IEnumerator MoveCoroutine()
    {
        while (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), transform.position.z);

            if (vector.x != 0)
                vector.y = 0;

            RaycastHit2D hit;
            Vector2 start = transform.position; ;
            Vector2 end = start + new Vector2(vector.x * speed * walkCount, vector.y * speed * walkCount);


            boxCollider.enabled = false;
            hit = Physics2D.Linecast(start, end, layerMask);
            boxCollider.enabled = true;


            if (hit.transform != null)
                break;

            while (currentWalkCount < walkCount)
            {
                if (vector.x != 0)
                {
                    transform.Translate(vector.x * speed, 0, 0);
                }
                else if (vector.y != 0)
                {
                    transform.Translate(0, vector.y * speed, 0);
                }
                yield return new WaitForSeconds(0.3f);
                currentWalkCount++;
            }
            currentWalkCount = 0;
        }
        canMove = true;
    }

    void Update()
    {
        Move();
        //Player X Direction
        if (Input.GetButtonDown("Horizontal"))
            sprite.flipX = Input.GetAxisRaw("Horizontal") == -1;


    }
    void Move()
    {
        if (canMove)
        {
            //Player MoveAnimation & move Check
            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                anim.SetBool("isWalk", true);
                canMove = false;
                StartCoroutine(MoveCoroutine());
            }
            else
            {
                anim.SetBool("isWalk", false);
            }
        }
    }
    //재활용가능
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().AddStamina();
            Debug.Log("피격 당함!!");
            OnDamaged();
        }
    }
    void OnDamaged()
    {
        gameObject.layer = 11;
        anim.SetBool("isBehit", true);
        StopAllCoroutines();
        Invoke("OffDamaged", 0.8f);
    }

    void OffDamaged()
    {
        gameObject.layer = 9;
        anim.SetBool("isBehit", false);
        StartCoroutine(MoveCoroutine());
    }
}