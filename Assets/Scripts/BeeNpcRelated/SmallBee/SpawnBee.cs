using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBee : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bees;
    [SerializeField] GameObject level1;
    void Start()
    {
      
          GameObject npc= Instantiate(bees, new Vector2(0, 0), transform.rotation);
        npc.transform.SetParent(level1.transform);
          
    }

   
}
