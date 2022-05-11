using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    
    public float Movementspeed;
    public int Dmg=10;
    public static GameObject enemy;
    private Vector2 target;
    private HealthManager healthmanager;
    private player player; 
    void Start()
    {
        player = PlayerManager.getPlayer();
        enemy = player.getEnemy();
        getenemytransform(enemy);
        healthmanager = enemy.GetComponent<HealthManager>();
    }

    public void getenemytransform(GameObject g)
    {
        Transform tenemy = g.transform;
        Debug.Log(tenemy);
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
            healthmanager.takeDMG(Dmg);
            Destroy_projectile();
        }
    }

    void Destroy_projectile()
    {
        Destroy(gameObject);
    }
    
}
