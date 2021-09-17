using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeNpcMovement : MonoBehaviour
{
    private float speed = 5f;
    [SerializeField] GameObject movetoPosition;
    
  
    private void Update()
    {
        moveTowardsAFlower();
    }
    private void moveTowardsAFlower()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,movetoPosition.transform.position,step);


        if(Vector3.Distance(transform.position,movetoPosition.transform.position) < 0.001f)
        {
            movetoPosition.transform.position *= -1.0f;
        }
    }
}
