using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insect
{

    private int armor;
   
    private int attackpower;
    private int health;
    private int[] exptoLvl=new int[10];

    public Insect(int health, int armor,int attackpower){

    
        this.health = health;
        this.armor = armor;
       
        this.attackpower = attackpower;
        

}
    public int damageTodeal()
    { int damage=0;
        return damage;
    }
    public void SetCurrHealth(int newHealth)
    {
        health = newHealth;
    }

    public int getHealth()
    {
        return health;
    }
    public int getArmor()
    {
        return armor;
    }

    public void SetAttackPower(int newAttackpower)
    {
        attackpower = newAttackpower;
    }

    public int getCurrentLevelExperience(int level)
    {
        return exptoLvl[level];
    }
    public void setExpNeededTOLevelUp()
    {
        for (int i=0;i<exptoLvl.Length;i++)
        {
            exptoLvl[i] = (500 * i) + 1;
        }
    }


}
