using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    [Header("오브젝트")]    

    [SerializeField]
    private GameObject warningTilefab;
    [SerializeField]
    private GameObject spear_energyPrefab;
    [SerializeField]
    private GameObject tail_energyPrefab;
    [SerializeField]
    private GameObject finger1_energyPrefab;
    [SerializeField]
    private GameObject finger2_energyPrefab;
    [SerializeField]
    private GameObject tail_effect;
    [SerializeField]
    private GameObject finger1_effect;
    [SerializeField]
    private GameObject finger2_effect;



    private Queue<WarningTile> Tile_Pooling_Object_Queue = new Queue<WarningTile>();

    private Queue<SpearEnergy> Spear_Pooling_Object_Queue = new Queue<SpearEnergy>();

    private Queue<Tail_Wave>  Tail_Pooling_Object_Queue = new Queue<Tail_Wave>();

    private Queue<Finger_Wave1> Finger1_Pooling_Object_Queue = new Queue<Finger_Wave1>();

    private Queue<Finger_Wave2> Finger2_Pooling_Object_Queue = new Queue<Finger_Wave2>();

    private Queue<Tail_Effect> effect_Pooling_Object_Queue = new Queue<Tail_Effect>();

    private Queue<Finger1_Effect> f1Effect_Pooling_Object_Queue = new Queue<Finger1_Effect>();

    private Queue<Finger2_Effect> f2Effect_Pooling_Object_Queue = new Queue<Finger2_Effect>();



    private void Awake()
    {
        Instance = this;

        /* Initialize(60, Tile_Pooling_Object_Queue);
         Initialize(50, Spear_Pooling_Object_Queue);
         Initialize(1 , Tail_Pooling_Object_Queue);
         Initialize(50, Finger1_Pooling_Object_Queue);
         Initialize(20, Finger2_Pooling_Object_Queue);
         */
        
    }

    private WarningTile TileNewObject()
    {
        var newObj = Instantiate(warningTilefab, transform).GetComponent<WarningTile>();
        newObj.gameObject.SetActive(false);
        return newObj;
    }

    private SpearEnergy SpearNewObject()
    {
        var se = Instantiate(spear_energyPrefab, transform).GetComponent<SpearEnergy>();
        se.gameObject.SetActive(false);
        return se;
    }

    private Tail_Wave TailNewObject()
    {
        var newObj = Instantiate(tail_energyPrefab, transform).GetComponent<Tail_Wave>();
        newObj.gameObject.SetActive(false);
        return newObj;
    }
    private Tail_Effect EffectNewObject()
    {
        var newObj = Instantiate(tail_effect, transform).GetComponent<Tail_Effect>();
        newObj.gameObject.SetActive(false);
        return newObj;
    }

    private Finger_Wave1 Finger1NewObject()
    {
        var newObj = Instantiate(finger1_energyPrefab, transform).GetComponent<Finger_Wave1>();
        newObj.gameObject.SetActive(false);
        return newObj;
    }
    private Finger_Wave2 Finger2NewObject()
    {
        var newObj = Instantiate(finger2_energyPrefab, transform).GetComponent<Finger_Wave2>();
        newObj.gameObject.SetActive(false);
        return newObj;
    }

    private Finger1_Effect f1_EffectNewObject()
    {
        var newObj = Instantiate(finger1_effect, transform).GetComponent<Finger1_Effect>();
        newObj.gameObject.SetActive(false);
        return newObj;
    }
    private Finger2_Effect f2_EffectNewObject()
    {
        var newObj = Instantiate(finger2_effect, transform).GetComponent<Finger2_Effect>();
        newObj.gameObject.SetActive(false);
        return newObj;
    }

    private void Initialize<T>(int count , T queue)
    {

        Queue newQueue = queue as Queue;



        for (int i = 0; i < count; i++)
        {
            newQueue.Enqueue(GetComponent<T>());
        }
    }


    public static WarningTile TileGetObject()
    {
        WarningTile tile;
        if(Instance.Tile_Pooling_Object_Queue.Count > 0)//빌려줄 오브젝트 있을때
        {
            tile = Instance.Tile_Pooling_Object_Queue.Dequeue();//Queue에서 꺼내다(?)
            
        }
        else//빌려줄 오브젝트 없을때
        {
            tile = Instance.TileNewObject();

        }
        tile.transform.SetParent(null);
        tile.gameObject.SetActive(true);

        return tile;
    }

    public static SpearEnergy SpearGetObject()
    {
        SpearEnergy se;
        if (Instance.Spear_Pooling_Object_Queue.Count > 0)//빌려줄 오브젝트 있을때
        {
            se = Instance.Spear_Pooling_Object_Queue.Dequeue();//Queue에서 꺼내다(?)

        }
        else//빌려줄 오브젝트 없을때
        {
            se = Instance.SpearNewObject();

        }
        se.transform.SetParent(null);
        se.gameObject.SetActive(true);

        return se;
    }

    public static Tail_Wave TailGetObject()
    {
        Tail_Wave tail;
        if (Instance.Tail_Pooling_Object_Queue.Count > 0)//빌려줄 오브젝트 있을때
        {
            tail = Instance.Tail_Pooling_Object_Queue.Dequeue();//Queue에서 꺼내다(?)
        }
        else//빌려줄 오브젝트 없을때
        {
            tail = Instance.TailNewObject();

        }
        tail.transform.SetParent(null);
        tail.gameObject.SetActive(true);

        return tail;
    }

    public static Tail_Effect EffectGetObject()
    {
        Tail_Effect effect;
        if (Instance.effect_Pooling_Object_Queue.Count > 0)//빌려줄 오브젝트 있을때
        {
            effect = Instance.effect_Pooling_Object_Queue.Dequeue();//Queue에서 꺼내다(?)
        }
        else//빌려줄 오브젝트 없을때
        {
            effect = Instance.EffectNewObject();

        }
        effect.transform.SetParent(null);
        effect.gameObject.SetActive(true);

        return effect;
    }

    public static Finger_Wave1 Finger1GetObject()
    {
        Finger_Wave1 finger1;
        if (Instance.Tail_Pooling_Object_Queue.Count > 0)//빌려줄 오브젝트 있을때
        {
            finger1 = Instance.Finger1_Pooling_Object_Queue.Dequeue();//Queue에서 꺼내다(?)
        }
        else//빌려줄 오브젝트 없을때
        {
            finger1 = Instance.Finger1NewObject();

        }
        finger1.transform.SetParent(null);
        finger1.gameObject.SetActive(true);

        return finger1;
    }

    public static Finger1_Effect f1EffectGetObject()
    {
        Finger1_Effect effect;
        if (Instance.f1Effect_Pooling_Object_Queue.Count > 0)//빌려줄 오브젝트 있을때
        {
            effect = Instance.f1Effect_Pooling_Object_Queue.Dequeue();//Queue에서 꺼내다(?)
        }
        else//빌려줄 오브젝트 없을때
        {
            effect = Instance.f1_EffectNewObject();

        }
        effect.transform.SetParent(null);
        effect.gameObject.SetActive(true);

        return effect;
    }
    public static Finger_Wave2 Finger2GetObject()
    {
        Finger_Wave2 finger2;
        if (Instance.Tail_Pooling_Object_Queue.Count > 0)//빌려줄 오브젝트 있을때
        {
            finger2 = Instance.Finger2_Pooling_Object_Queue.Dequeue();//Queue에서 꺼내다(?)
        }
        else//빌려줄 오브젝트 없을때
        {
            finger2 = Instance.Finger2NewObject();

        }
        finger2.transform.SetParent(null);
        finger2.gameObject.SetActive(true);

        return finger2;
    }

    public static Finger2_Effect f2EffectGetObject()
    {
        Finger2_Effect effect;
        if (Instance.f2Effect_Pooling_Object_Queue.Count > 0)//빌려줄 오브젝트 있을때
        {
            effect = Instance.f2Effect_Pooling_Object_Queue.Dequeue();//Queue에서 꺼내다(?)
        }
        else//빌려줄 오브젝트 없을때
        {
            effect = Instance.f2_EffectNewObject();

        }
        effect.transform.SetParent(null);
        effect.gameObject.SetActive(true);

        return effect;
    }



    public static void EnQueueObject(WarningTile tile)
    {
        tile.gameObject.SetActive(false);

        var spr = tile.GetComponent<SpriteRenderer>();
        spr.color = Color.white;
        tile.transform.SetParent(Instance.transform);
        Instance.Tile_Pooling_Object_Queue.Enqueue(tile);//Queue에서
        //나는 Enemy 를 넣는다고 생각했었다.
    }

    public static void EnQueueObject(SpearEnergy spear)
    {
        spear.gameObject.SetActive(false);

        var spr = spear.GetComponent<SpriteRenderer>();
        spr.color = Color.white;
        spear.transform.SetParent(Instance.transform);
        Instance.Spear_Pooling_Object_Queue.Enqueue(spear);//Queue에서
    }

    public static void EnQueueObject(Tail_Wave tail)
    {
        tail.gameObject.SetActive(false);

        var spr = tail.GetComponent<SpriteRenderer>();
        spr.color = Color.white;
        tail.transform.SetParent(Instance.transform);
        Instance.Tail_Pooling_Object_Queue.Enqueue(tail);//Queue에서
    }

    public static void EnQueueObject(Finger_Wave1 finger1)
    {
        finger1.gameObject.SetActive(false);

        var spr = finger1.GetComponent<SpriteRenderer>();
        spr.color = Color.white;
        finger1.transform.SetParent(Instance.transform);
        Instance.Finger1_Pooling_Object_Queue.Enqueue(finger1);//Queue에서
    }

    public static void EnQueueObject(Finger_Wave2 finger2)
    {
        finger2.gameObject.SetActive(false);

        var spr = finger2.GetComponent<SpriteRenderer>();
        spr.color = Color.white;
        finger2.transform.SetParent(Instance.transform);
        Instance.Finger2_Pooling_Object_Queue.Enqueue(finger2);//Queue에서
    }

    public static void EnQueueObject(Tail_Effect effect)
    {
        effect.gameObject.SetActive(false);

        var spr = effect.GetComponent<SpriteRenderer>();
        spr.color = Color.white;
        effect.transform.SetParent(Instance.transform);
        Instance.effect_Pooling_Object_Queue.Enqueue(effect);//Queue에서
    }

    public static void EnQueueObject(Finger1_Effect effect)
    {
        effect.gameObject.SetActive(false);

        var spr = effect.GetComponent<SpriteRenderer>();
        spr.color = Color.white;
        effect.transform.SetParent(Instance.transform);
        Instance.f1Effect_Pooling_Object_Queue.Enqueue(effect);//Queue에서
    }
    public static void EnQueueObject(Finger2_Effect effect)
    {
        effect.gameObject.SetActive(false);

        var spr = effect.GetComponent<SpriteRenderer>();
        spr.color = Color.white;
        effect.transform.SetParent(Instance.transform);
        Instance.f2Effect_Pooling_Object_Queue.Enqueue(effect);//Queue에서
    }
}
