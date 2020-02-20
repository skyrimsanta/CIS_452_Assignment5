using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBullet : MonoBehaviour
{
    protected SpriteRenderer sr;
    public float speed;
    private float currentTime;

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
