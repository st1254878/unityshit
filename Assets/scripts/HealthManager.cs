using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int maxHealth;
    private int curHealth;
    private float lerptimer;
    void Start()
    {
        healthsetting();
    }
    void healthsetting()
    {
       curHealth = maxHealth;
    }

    public void takeDMG(int dmg)
    {
        lerptimer = 0f;
        curHealth-=dmg;
        if(curHealth<0) curHealth = 0;
    }

    public float getLerpTimer()
    {
        return lerptimer;
    }

    public int getMaxHealth()
    {
        return maxHealth;
    }
    public int getCurHealth()
    {
        return curHealth;
    }
    public float getCurHealthRate()
    {
        return (float)getCurHealth()/getMaxHealth();
    }
}
