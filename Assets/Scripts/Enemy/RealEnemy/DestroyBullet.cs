using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag=="Collider")
        {
            Destroy(gameObject);
        }
        if (collision.transform.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (collision.transform.tag == "Block")
        {
            Destroy(gameObject);
        }
    }
}
