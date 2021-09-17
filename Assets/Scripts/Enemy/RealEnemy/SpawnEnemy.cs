using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject position;
    private bool spawnOnce;
    void spawnEnemy()
    {
        if (spawnOnce == false)
        {
            Instantiate(enemy, new Vector2(position.transform.position.x, position.transform.position.y), position.transform.rotation);
        }
        spawnOnce = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Spawn");
      /*  if ()
        {
          
        }
      */
        spawnEnemy();
    }

  
   

}
