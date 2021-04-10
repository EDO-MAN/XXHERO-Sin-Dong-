using System.Collections;
using System.Threading;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    Animator anim;

    [SerializeField]
    private Transform playerTransform;

    

    [SerializeField]
    private float timer = 0.0f;

    public const float value = 0.38f;

    void Awake()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(Think());
    }
    // 함수는 무조건 동사로
    // 남이봐도 알수있게
    IEnumerator Spear_Attack()
    {
       
        Vector2 vec = playerTransform.position;
        float y = vec.y;
        float tile_y = 0f;

        for (int i = 0; i < 7; i++)
        {
            WarningTile war = ObjectPool.TileGetObject();
            Vector2 newVec = new Vector2(0.47f - i, (y + 0.45f) - value);
            war.transform.position = newVec;
            tile_y = newVec.y;

            yield return null;
            StartCoroutine(WarningDestory(war));
        }
        StartCoroutine(Spear_Wave(tile_y));
    }

    IEnumerator Spear_Wave(float y)
    {

        SpearEnergy wave = ObjectPool.SpearGetObject();
        
        wave.transform.position = new Vector3(0.44f, y , 0);
        
        //wave = new SpearEnergy();//메모리에 새로 생성.
        yield return new WaitForSeconds(1.0f);
    }
    IEnumerator Tail_Attack()
    {
        Vector3 vec = playerTransform.position;
        float x = vec.x;


        /*for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                WarningTile war = ObjectPool.TileGetObject();
                Vector3 newVec = new Vector3(x +1.06f - j, -3.54f + i, 0);
               

                war.transform.position = newVec;


                yield return null;
                //yield return new WaitForSeconds(2.0f);
                StartCoroutine(WarningDestory(war));
            }
        }*/
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                WarningTile war = ObjectPool.TileGetObject();

                if (vec.x <= -5)
                {
                    
                    Vector3 newVec = new Vector3(x + 1.06f - i + 1 , -3.54f + j, 0);
                    war.transform.position = newVec;
                }
                else if(vec.x >= 0.35f)
                {
                    Vector3 newVec = new Vector3(x + 1.06f - i - 1, -3.54f + j, 0);
                    war.transform.position = newVec;
                }
                else
                {
                    Vector3 newVec = new Vector3(x + 1.06f - i, -3.54f + j, 0);
                    war.transform.position = newVec;
                }
                yield return null;
                //yield return new WaitForSeconds(2.0f);
                StartCoroutine(WarningDestory(war));
            }
        }
        StartCoroutine(Tail_Wave());
    }

    IEnumerator Tail_Wave()
    {
        Vector2 vec = playerTransform.position;
        float x = vec.x;
        Tail_Wave wave = ObjectPool.TailGetObject();
        if (vec.x <= -5)
        {
            wave.transform.position = new Vector3(x + 1.238f, -0.66f, 0);
        }
        else if (vec.x >= 0.35f)
        {
            wave.transform.position = new Vector3(x + 0.238f - 1.0f, -0.66f, 0);
        }
        else
        {
            wave.transform.position = new Vector3(x + 0.238f, -0.66f, 0);
        }
            yield return new WaitForSeconds(1.0f);
    }

    IEnumerator Tail_Effect()
    {
        Vector2 vec = playerTransform.position;
        float x = vec.x;

        Tail_Effect effect = ObjectPool.EffectGetObject();
        if (vec.x <= -5)
        {

            effect.transform.position = new Vector3(x + 1.1f, -0.56f, 0);
        }
        else if (vec.x >= 0.35f)
        {
            effect.transform.position = new Vector3(x - 0.9f, -0.56f, 0);
        }
        else
        {
            effect.transform.position = new Vector3(x + 0.1f, -0.56f, 0);
        }
        StartCoroutine(Tail_Effect_Destory(effect));
        yield return new WaitForSeconds(5.0f);
    }

    IEnumerator Finger1_Attack()
    {
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                WarningTile war = ObjectPool.TileGetObject();
                Vector2 newVec = new Vector2(0.47f - i, (0.9f - j) - value);
                war.transform.position = newVec;

                yield return null;
                StartCoroutine(WarningDestory(war));
            }
        }
        StartCoroutine(Finger1_Wave());
    }

    IEnumerator Finger1_Wave()
    {
        Finger_Wave1 wave = ObjectPool.Finger1GetObject();
        wave.transform.position = new Vector3(0, -0.5f, 0);
        //wave = new SpearEnergy();//메모리에 새로 생성.
        yield return new WaitForSeconds(1.0f);
    }

    IEnumerator Finger1_Effect()
    {
        Finger1_Effect effect = ObjectPool.f1EffectGetObject();
        effect.transform.position = new Vector3(-2.69f, -0.5f, 0);

        StartCoroutine(Effect_Destory(effect) );
        yield return new WaitForSeconds(1.0f);
    }

    IEnumerator Finger2_Attack()
    {
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                WarningTile war = ObjectPool.TileGetObject();
                Vector2 newVec = new Vector2((-3.55f + 0.05f) + j, (2.36f + 0.15f) - i);
                war.transform.position = newVec;

                yield return null;
                StartCoroutine(WarningDestory(war));
            }
        }
        StartCoroutine(Finger2_Wave());
    }

    IEnumerator Finger2_Wave()
    {
        Finger_Wave2 wave = ObjectPool.Finger2GetObject();
        wave.transform.position = new Vector3(-2.55f, -3.58f, 0);
        //wave = new SpearEnergy();//메모리에 새로 생성.
        yield return new WaitForSeconds(1.0f);
    }

    IEnumerator Finger2_Effect()
    {
        Finger2_Effect effect = ObjectPool.f2EffectGetObject();
        effect.transform.position = new Vector3(-2.54f, -0.52f, 0);

        StartCoroutine(Effect_Destory(effect));
        yield return new WaitForSeconds(1.0f);
    }


    IEnumerator WarningDestory(WarningTile war)
    {
        SpriteRenderer spr = war.GetComponent<SpriteRenderer>();
        Color temColor = spr.color;
        float a = spr.color.a;

        yield return null;

        while (a > 0.01f)
        {
            spr.color = new Color(temColor.r, temColor.g, temColor.b, a);
            yield return null;
            a -= Time.deltaTime;

        }
        //반복분이끝나고
        //알파값이 완전 작아져서 완전히 투명해져가는 상태


        // 회수를 하는 함수죠
        // Warningtile 을 회수 하는 함수에요
        ObjectPool.EnQueueObject(war);

    }

    IEnumerator Tail_Effect_Destory(Tail_Effect war)
    {
        SpriteRenderer spr = war.GetComponent<SpriteRenderer>();

        Color temColor = spr.color;
        float a = spr.color.a;

        yield return null;

        while (a > 0.01f)
        {
            spr.color = new Color(temColor.r, temColor.g, temColor.b, a);
            yield return null;
            a -= Time.deltaTime;

        }
        ObjectPool.EnQueueObject(war);
    }

    IEnumerator Effect_Destory(Finger1_Effect war)
    {
        SpriteRenderer spr = war.GetComponent<SpriteRenderer>();
        Color temColor = spr.color;
        float a = spr.color.a;

        yield return null;

        while (a > 0.01f)
        {
            spr.color = new Color(temColor.r, temColor.g, temColor.b, a);
            yield return null;
            a -= Time.deltaTime;

        }
        ObjectPool.EnQueueObject(war);
    }

    IEnumerator Effect_Destory(Finger2_Effect war)
    {
        SpriteRenderer spr = war.GetComponent<SpriteRenderer>();
        Color temColor = spr.color;
        float a = spr.color.a;

        yield return null;

        while (a > 0.01f)
        {
            spr.color = new Color(temColor.r, temColor.g, temColor.b, a);
            yield return null;
            a -= Time.deltaTime;

        }
        ObjectPool.EnQueueObject(war);
    }


    IEnumerator Think()
    {
        yield return new WaitForSeconds(1.5f);

        int ranAction = Random.Range(0, 3);
        switch (ranAction)
        {
            //case 0:
            case 0:
                //손톱 공격 모션
                StartCoroutine(Finger_Mot());

                break;
            case 1:
                //창 공격 모션
                StartCoroutine(Spear_Mot());
                break;
            case 2:
                //꼬리 공격 모션
                StartCoroutine(Tail_Mot());
                break;
        }
    }
    IEnumerator Finger_Mot()
    {
        anim.SetTrigger("doFingerAttack");
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(Think());
    }
    IEnumerator Spear_Mot()
    {
        anim.SetTrigger("doSpearAttack");
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(Think());
    }
    IEnumerator Tail_Mot()
    {
        anim.SetTrigger("doTailAttack");
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(Think());
    }
}
