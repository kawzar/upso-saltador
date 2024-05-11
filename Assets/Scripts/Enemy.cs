using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private const string PlayerTag = "Player";
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == PlayerTag)
        {
            
        }
    }
}
