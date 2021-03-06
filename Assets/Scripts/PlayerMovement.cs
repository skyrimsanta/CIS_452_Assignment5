﻿/*
 * (Levi Schoof)
 * (PlayerMovement)
 * (Assignment 5)
 * (Handles the rotation and movement of the player)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10;
    Vector3 newPos;
    private Vector3 mousePosition;

    private void FixedUpdate()
    {
     
        Movement();


    }

    private void Update()
    {
        Rotation();
    }

    private void Movement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        newPos = this.transform.position;

        newPos.x += h * moveSpeed * Time.deltaTime;
        newPos.y += v * moveSpeed * Time.deltaTime;

        transform.position = newPos;
        
    }

    private void Rotation()
    {
        //Get the Screen positions of the object
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);

        //Get the Screen position of the mouse
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

        //Get the angle between the points
        float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));

    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
