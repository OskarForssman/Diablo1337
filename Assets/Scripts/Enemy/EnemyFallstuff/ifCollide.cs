using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifCollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {

            Destroy(gameObject);
        }

        if (collider.gameObject.tag == "Collider")
        {
           
            Destroy(gameObject);
        }

       
    }
}

