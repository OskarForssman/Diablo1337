using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateForMe : MathInterFaceFordmgetc
{
    public int calculateDamage(int damage, int armor, int health)
    {

        return health - (damage - armor);
    }
}
