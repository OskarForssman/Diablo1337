using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SpawnStone : MonoBehaviour
{
    
    [SerializeField] GameObject stone;
    private int i=0;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {

    



        if (Time.time > i)
        {
            i += 5;            SpawnStoneNow();
        }
       
        
        
    }

    void SpawnStoneNow()
    {
        Tilemap tilemap = GetComponent<Tilemap>();
        
                     

        for (int x = 0; x < tilemap.size.x; x++)
        {
            for (int y = 0; y < tilemap.size.y; y++)
            {
                Vector3Int localPlace = (new Vector3Int(x, y,0));
                Vector3 place = tilemap.CellToWorld(localPlace);
                if (tilemap.HasTile(localPlace))
                {
                    GameObject stonez = Instantiate(stone, place, transform.rotation);
                    stonez.transform.SetParent(gameObject.transform);
                }
                else
                {
                    //No tile at "place"
                }

            }
        }


     
    }

   
}
