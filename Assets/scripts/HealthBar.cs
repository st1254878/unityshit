using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Transform myPos;
    private float lerptimer;
    public float chipspeed = 1f;
    public AnimationCurve curve;
    public float animationCom;
    private HealthManager healthmanager;
    private float CurSliderValue;
    private Animator animator;
    private float tempStartValue;
    void Update()
    {

        transform.position = myPos.position;
        float nxtHealthRate = healthmanager.getCurHealthRate()*100;
        if(CurSliderValue != nxtHealthRate)
        {
            animator.SetBool("New Bool",true);
            lerptimer = 0f;
            tempStartValue = CurSliderValue;
            CurSliderValue = nxtHealthRate;
        }
        if(lerptimer < chipspeed)
        {
            lerptimer += Time.deltaTime;
            anime();
        }
        else
        {
            animator.SetBool("New Bool",false);
        }
    }
    
    void anime()
    {
        float complete = lerptimer / chipspeed;
        //float nowValue = tempStartValue + (CurSliderValue-tempStartValue)*curve.Evaluate(complete);
        float nowValue = tempStartValue + (CurSliderValue-tempStartValue)*animationCom;
        slider.value = nowValue;
    /*  float starttime = 0f;
        float endtime = 30f;
        float startvalue = slider.value;
        float endvalue = total; */

    }

    public void set_Heath_Manager(HealthManager m)
    {
        healthmanager = m;
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        slider.value = healthmanager.getCurHealthRate()*100;
    }
    

}
