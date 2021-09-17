using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class RetriveSlowUsDownTiles : MonoBehaviour
{
    Tilemap tilemap;
    // Start is called before the first frame update
    List<Vector3> positionForSlowDownTIles;
    void Start()
    {
         positionForSlowDownTIles = new List<Vector3>();
         tilemap = GetComponent<Tilemap>();
        for(int i = 0; i < tilemap.size.x;i++)
        {
            for(int j = 0; j < tilemap.size.y; j++)
            {
                Vector3Int v3toV3int = new Vector3Int(i,j, 0);
                Vector3 convertedtilestov3 = tilemap.CellToWorld(v3toV3int);

                if (tilemap.HasTile(v3toV3int))
                {
                    positionForSlowDownTIles.Add(convertedtilestov3);
                }
            }
        }
    }


    public List<Vector3> getArrayListOfSlowDownTiles()
    {
        return positionForSlowDownTIles;
    }

}
