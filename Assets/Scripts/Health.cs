using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int curHP;
    public int maxHealth = 3;

    public Health healthBar;
    public Slider slider;

    void Start()
    {
        curHP = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDmg(1);
        }
    }

    public void SetMaxHealth(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;
    }

    public void setHealth(int hp)
    {
        slider.value = hp;
    }

  
    void TakeDmg(int dmg)
    {
        curHP -= dmg;
             
        healthBar.setHealth(curHP);

        //if(curHP <= 0){
        //play the ending screen or something
        //}
    }
}
