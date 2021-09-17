using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyStupidBullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D rigid;
   
  

    
public void shoot(Vector2 direction)
    {
        
              

    
            rigid.velocity = direction;
        
    }
    
}
