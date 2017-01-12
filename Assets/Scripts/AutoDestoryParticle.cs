﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestoryParticle : MonoBehaviour {

    public class DestroyParticles : MonoBehaviour
    {


        private float timeLeft;
        public void Awake()
        {
            ParticleSystem system = GetComponent<ParticleSystem>();
            timeLeft = system.startLifetime;
        }
        public void Update()
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                GameObject.Destroy(gameObject);
            }
        }


    }
}
