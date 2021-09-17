using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPickedUp
{
    private float amountOfFlower;


    public void setFlower(float flower)
    {
        amountOfFlower = amountOfFlower+ flower;
    }

    public float getFlower()
    {
        return amountOfFlower;
    }
   
}
