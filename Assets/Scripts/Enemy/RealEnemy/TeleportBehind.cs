using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TeleportBehind : MonoBehaviour
{
    GameObject player;
    FlyStupidBullet bullet1;
    [SerializeField] GameObject bullet;
    List<Vector3> res;
    // Start is called before the first frame update
    float timeleft = 2f;
    TileBase[] tiles;
    void Start()
    {
      res= FindObjectOfType<RetriveSlowUsDownTiles>().getArrayListOfSlowDownTiles();
    }

    // Update is called once per frame
    void Update()
    {
        
              GameObject player = GameObject.FindGameObjectWithTag("Player");
        timeleft -= Time.deltaTime;
        if (timeleft < 0)
        {

            if (player != null)
            {

                if (Vector3.Distance(player.transform.position, gameObject.transform.position) < 10)
                {

                    Shoot(player);
                    timeleft = 2f;
                }

            }
            else
            {
                //DO nothing
            }

        }




    }
void Shoot(GameObject player)
    {




        Vector3 position;

        int random=Random.Range(1,4);
        switch(random){
            case 1:

                 position = new Vector3(player.transform.position.x + 3, player.transform.position.y, 0);
                if (checkifpositionpossible(position))
                {
                gameObject.transform.position = new Vector3(player.transform.position.x + 3, player.transform.position.y, 0 );
                bullet1 = Instantiate(bullet, new Vector2(gameObject.transform.position.x -1, gameObject.transform.position.y), gameObject.transform.rotation)?.GetComponent<FlyStupidBullet>();
                bullet1.shoot(new Vector2(-1f, 0));
                }
                else
                {
                    Shoot(player);
                }
                break;
            case 2:
                 position = new Vector3(player.transform.position.x - 3, player.transform.position.y,0);
                if (checkifpositionpossible(position))
                {
                    gameObject.transform.position = new Vector3(player.transform.position.x - 3, player.transform.position.y,0);
                    bullet1 = Instantiate(bullet, new Vector2(gameObject.transform.position.x + 1, gameObject.transform.position.y), gameObject.transform.rotation)?.GetComponent<FlyStupidBullet>();
                    bullet1.shoot(new Vector2(1f, 0));
                }
                else
                {
                    Shoot(player);
                }
           
          

                break;
            case 3:
                position = new Vector3(player.transform.position.x, player.transform.position.y - 3,0);
                if (checkifpositionpossible(position))
                {
                    gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 3,0);
                    bullet1 = Instantiate(bullet, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 1), gameObject.transform.rotation)?.GetComponent<FlyStupidBullet>();
                    bullet1.shoot(new Vector2(0, 1f));
                }
                else
                {
                    Shoot(player);
                }

               
                   break;
            case 4:

                position = new Vector3(player.transform.position.x, player.transform.position.y + 3);
                if (checkifpositionpossible(position))
                {
                    bullet1 = Instantiate(bullet, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1), gameObject.transform.rotation)?.GetComponent<FlyStupidBullet>();
                    bullet1.shoot(new Vector2(0, -1f));
                   
                }
                else
                {
                    Shoot(player);
                }
         
                break;
                
        }
      
    }
    bool checkifpositionpossible(Vector3 position)
    {
        for (int i = 0; i < res.Count; i++)
        {
            if (Vector3.Distance(res[i], position) < 1f)
            {
                return true;
            }
        }
        return false;
    }
  
       
    
    

}
