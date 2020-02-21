/*
 * (Levi Schoof)
 * (BlueBullet)
 * (Assignment 5)
 * (Inherants from BaseBullet and makes the Bullet blue)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBullet : BaseBullet
{

    // Start is called before the first frame update
    new void Start()
    {
        changeColor = Color.blue;
        base.Start();
        sr.color = changeColor;
    }

}
