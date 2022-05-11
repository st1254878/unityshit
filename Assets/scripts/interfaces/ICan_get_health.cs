using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICan_get_health
{
    public  int getCurHealth();
    public  int getMaxHealth();
    public  void takeDMG(int d);
}