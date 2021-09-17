using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    Insect insect;
    CalculateForMe calc;
  
  
    private void Start()
    {
       
    insect = new Insect(50, 2, 10);
         calc=new CalculateForMe();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.transform.tag == "MyBullet")
        {
          
           int damagetaken=calc.calculateDamage(10,insect.getArmor(),insect.getHealth());
           insect.SetCurrHealth(damagetaken);
            if (insect.getHealth() <= 0)
            {
               
                Destroy(gameObject);
                
                DestroyBlock();
               
            }
           
        }
    }
    void DestroyBlock()
    {
       
        GameObject[] block = GameObject.FindGameObjectsWithTag("Block");
        for(int i = 0; i < block.Length; i++)
        {
            Destroy(block[0]);
        }
       
    }
}


