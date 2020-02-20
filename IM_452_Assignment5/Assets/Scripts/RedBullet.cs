using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : BaseBullet
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        sr.color = Color.red;
    }
}
