using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rd;
    public float movementspeed;
    private Vector2 movedir;
    public GameObject projectile;
    public GameObject enemy;
    public Transform projectilePos;
    public Skill ski;


    public int maxHealth,curHealth;
    // Start is called before the first frame update
    void Start()
    {
        PlayerManager.setPlayer(this);
        enemy = GameObject.FindGameObjectsWithTag("enemy")[0];
        rd = GetComponent<Rigidbody2D>();
    }
    public GameObject getEnemy()
    {
        return enemy;
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
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            ski.cast();
        }
        float movex = Input.GetAxisRaw("Horizontal");
        float movey = Input.GetAxisRaw("Vertical");
        movedir = new Vector2(movex,movey).normalized;
    }   
    
    void move()
    {
        rd.velocity = new Vector2(movedir.x*movementspeed,movedir.y*movementspeed);
    }
}
