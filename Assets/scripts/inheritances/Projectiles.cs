using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float Movementspeed;
    public int Dmg;
    private GameObject enemy;
    private Transform tenemy;
    private Vector2 target;
    void Start()
    {
        getenemytransform(transform);
        getenemy(gameObject);
    }
    
    public void getenemy(GameObject g)
    {
        enemy = g;
    }
    public void getenemytransform(Transform g)
    {
        tenemy = g;
        target = new Vector2(tenemy.position.x,tenemy.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    
    protected virtual void move()
    {
        transform.position = Vector2.MoveTowards(transform.position,target,Movementspeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("enemy"))
        {
            Destroy_projectile();
        }
    }

    void Destroy_projectile()
    {
        Destroy(gameObject);
    }
    
}
