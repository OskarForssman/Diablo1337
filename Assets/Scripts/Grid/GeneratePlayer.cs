using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GeneratePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject player;
    [SerializeField] GameObject spawnpoint;
    
    void Start()
    {
        //Instantiate(player, spawnpoint.transform.position, player.transform.rotation);
        
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            SpawnPlayerIfYouDie();
        }

    }


      void SpawnPlayerIfYouDie()
    {
       Instantiate(player, spawnpoint.transform.position, player.transform.rotation);
        
    }

    
}
