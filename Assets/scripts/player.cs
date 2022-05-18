using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Animator animator;
    public Rigidbody2D rd;
    public float movementspeed;
    private Vector2 movedir;
    public GameObject projectile;
    public GameObject enemy;
    public Transform projectilePos;
    public float TimeBetweenSKill = 2f;
    private float TimeAfterLastSkill;
    public Skill ski;
    private bool canMove;
    public HealthBar healthbar_no_prefab;
    public Transform healthbar_position;
    public HealthManager healthmanager;

    // Start is called before the first frame update

    public void Attack()
    {
        ski.cast();
    }
    void Start()
    {
        canMove = true;
        TimeAfterLastSkill = 2;
        animator = GetComponent<Animator>();
        creat_new_healthbar();
        PlayerManager.setPlayer(this);
        enemy = GameObject.FindGameObjectsWithTag("enemy")[0];
        rd = GetComponent<Rigidbody2D>();
    }
    public GameObject getEnemy()
    {
        return enemy;
    }

    void creat_new_healthbar()
    {
        HealthBar bar = Instantiate(healthbar_no_prefab,GameObject.FindGameObjectsWithTag("canvas")[0].transform);
        bar.set_Heath_Manager(healthmanager);
        bar.myPos = healthbar_position;
    }

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        move();
    }
    void ProcessInputs()
    {
        if(TimeAfterLastSkill<TimeBetweenSKill)
        { 
            canMove = false;   
        }
        else canMove = true;
        TimeAfterLastSkill += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(TimeAfterLastSkill>=TimeBetweenSKill)
            { 
                animator.SetTrigger("isAttack");
                TimeAfterLastSkill = 0f;
            }
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isWalking",true);
        }
        else
        {
            animator.SetBool("isWalking",false);    
        }
        float movex = Input.GetAxisRaw("Horizontal");
        float movey = Input.GetAxisRaw("Vertical");
        movedir = new Vector2(movex,movey).normalized;
    }   
    
    void move()
    {
        if(!canMove)
        {
            rd.velocity = Vector2.zero;
            return;
        }
        rd.velocity = new Vector2(movedir.x*movementspeed,movedir.y*movementspeed);
    }
}
