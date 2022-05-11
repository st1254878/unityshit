using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public  GameObject target;
    private HealthManager healthmanager;
    void Update()
    {
        slider.value = healthmanager.getCurHealthRate()*100;
        Debug.Log(healthmanager.getCurHealthRate()*100);
    }
   
    void Start()
    {
        healthmanager = target.GetComponent<HealthManager>();
    }
    

}
