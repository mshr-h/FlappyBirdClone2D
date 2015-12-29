﻿using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
    public Vector2 velocity = new Vector2(-4, 0);
    public float range = 4;

    void Start () {
        GetComponent<Rigidbody2D>().velocity = velocity;
        GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	}

    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < -100)
        {
            Destroy(gameObject);
        }
    }
}
