﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateYaxis : MonoBehaviour
{

	public float randomSpeed;
    // Use this for initialization
    void Start()
    {
        randomSpeed = Random.Range(1.0f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, randomSpeed, 0);
    }
}
