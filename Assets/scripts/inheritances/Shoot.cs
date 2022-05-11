using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Skill
{
    public float dmg;
    public GameObject bullet;
    public Transform launch;
    private Fireball fireball;
    void Start()
    {
        
    }
   
    public override void cast()
    {
        Instantiate(bullet,launch.position,Quaternion.identity);
    }
}
