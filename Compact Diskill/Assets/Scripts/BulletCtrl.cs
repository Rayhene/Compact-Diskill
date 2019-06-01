﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public Vector2 speed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = speed;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        gameObject.SetActive(false);    
    }

     

}
