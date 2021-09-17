using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasePlayer : MonoBehaviour
{
    // Start is called before the first frame update

    private float  speed = 0.5f;
  
    
    [SerializeField] GameObject bullet;

   
    bool spawn=true;
    FlyStupidBullet bullet1, bullet2, bullet3, bullet4;
    // Update is called once per frame

    
    void Update()
    {

        if (GameObject.FindGameObjectsWithTag("Player") != null)
        {

            GameObject player = GameObject.FindGameObjectWithTag("Player");

            if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= 10f)
            {
               

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, step);

        if(Vector3.Distance(gameObject.transform.position, player.transform.position) <= 5f )
        {

            shootnow();

        }
            }
        }

    }
    public void shootnow()
    {



        if (spawn)
        {
         //viktigt!
           
            bullet1= Instantiate(bullet,new Vector2(gameObject.transform.position.x+1, gameObject.transform.position.y), gameObject.transform.rotation)?.GetComponent<FlyStupidBullet>();
            bullet1.shoot(new Vector2(2.5f,0));
             bullet2 = Instantiate(bullet, new Vector2(gameObject.transform.position.x - 1, gameObject.transform.position.y), gameObject.transform.rotation)?.GetComponent<FlyStupidBullet>();
            bullet2.shoot(new Vector2(-2.5f, 0));
             bullet3 = Instantiate(bullet, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 1), gameObject.transform.rotation)?.GetComponent<FlyStupidBullet>();
            bullet3.shoot(new Vector2(0, -2.5f));
             bullet4 = Instantiate(bullet, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 1), gameObject.transform.rotation)?.GetComponent<FlyStupidBullet>();
            bullet4.shoot(new Vector2(0, 2.5f));
            spawn = false;
        }
        
        if(GameObject.FindGameObjectWithTag("Bullet")==null)
        {
            spawn = true;
        }


    }

  
}




