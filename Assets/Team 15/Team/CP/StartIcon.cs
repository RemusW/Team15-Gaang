﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartIcon : MonoBehaviour
{
    SpriteRenderer sr;
    [SerializeField]
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position = transform.position + new Vector3(0, -0.02f, 0);

    }
}