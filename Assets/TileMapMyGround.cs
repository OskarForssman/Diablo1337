using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapMyGround : MonoBehaviour
{
    // Start is called before the first frame update
    TileBase[] tiles;
    void Start()
    {

        Tilemap tilemap = GetComponent<Tilemap>();
        BoundsInt bounds = tilemap.cellBounds;
        tiles = tilemap.GetTilesBlock(bounds);

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
