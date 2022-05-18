using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public HealthBar healthbar_no_prefab;
    public Transform healthbar_position;
    public HealthManager healthmanager;
    void Start()
    {
         creat_new_healthbar();
    }

    void creat_new_healthbar()
    {
        HealthBar bar = Instantiate(healthbar_no_prefab,GameObject.FindGameObjectsWithTag("canvas")[0].transform);
        bar.set_Heath_Manager(healthmanager);
        bar.myPos = healthbar_position;
    }

   
    void Update()
    {
        
    }

}
