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
        curHealth-=dmg;
        if(curHealth<0) curHealth = 0;
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
