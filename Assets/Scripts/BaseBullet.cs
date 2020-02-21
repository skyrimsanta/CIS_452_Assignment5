/*
 * (Levi Schoof)
 * (BaseBullet)
 * (Assignment 5)
 * (Handles the Base class of the bullet and handles the death of the bullets)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBullet : MonoBehaviour
{
    protected SpriteRenderer sr;
    public float speed;
    private float currentTime;
    public Color changeColor;

    public void Start()
    {
        sr = this.GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        currentTime += Time.deltaTime;
        
        if(currentTime > 5)
        {
            Destroy(this.gameObject);
        }
    }
}
