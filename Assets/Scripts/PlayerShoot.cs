/*
 * (Levi Schoof)
 * (PlayerShoot)
 * (Assignment 5)
 * (The client class that feeds information in the BulletFactory)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private BulletFactory bulletFactory;
    private float shootDelay = .3f;
    private float currentTime = 0;

    private void Start()
    {
        bulletFactory = FindObjectOfType<BulletFactory>();
    }
    void Update()
    {
        currentTime += Time.deltaTime;
        PlayerFire();
    }

    private void PlayerFire()
    {
        if(currentTime >= shootDelay)
        {
            if (Input.GetMouseButtonDown(0))
            {
                currentTime = 0;
                bulletFactory.CreateBullet("blue", 40, this.transform);
            }

            else if (Input.GetMouseButtonDown(1))
            {
                currentTime = 0;
                bulletFactory.CreateBullet("red", 40, this.transform);
            }
        }

    }
}
