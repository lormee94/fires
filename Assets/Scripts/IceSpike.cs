﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpike : MonoBehaviour
{
    private Rigidbody2D rb;

    private bool fallen = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!fallen && !col.gameObject.CompareTag("Player"))
        {
            if (col.otherCollider is BoxCollider2D)
            {
                fallen = true;
                GetComponent<AudioSource>().Play();
                rb.gravityScale = 0.9f;
            }
        }
    }
}
