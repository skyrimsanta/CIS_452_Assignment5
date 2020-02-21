/*
 * (Levi Schoof)
 * (RedBullet)
 * (Assignment 5)
 * (Inherants from BaseBullet and makes the Bullet red)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : BaseBullet
{
    // Start is called before the first frame update
    new void Start()
    {
        changeColor = Color.red;
        base.Start();
        sr.color = changeColor;
    }
}
