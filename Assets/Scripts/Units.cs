using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units 
{
    public static Units instance { get; private set; }
    public float health;
    public float healthMax = 100;
    public float damage = 20;
}
