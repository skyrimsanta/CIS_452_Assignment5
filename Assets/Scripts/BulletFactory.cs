/*
 * (Levi Schoof)
 * (BulletFactory)
 * (Assignment 5)
 * (The Factory that handles the creation of the two types of bullets)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    public GameObject baseBullet;

    public void CreateBullet(string bulletType, float bulletSpeed, Transform pos)
    {
        GameObject bullet = Instantiate(baseBullet);
        bullet.transform.position = pos.position;
     
        var bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.velocity = ((pos.right * -1) * bulletSpeed);
        bullet.transform.parent = null;
        bullet.transform.localScale = new Vector3(20, 20, 1);

        switch (bulletType)
        {
            case "red":
                bullet.AddComponent<RedBullet>();
                break;
            case "blue":
                bullet.AddComponent<BlueBullet>();
                break;
        }
    }
}
