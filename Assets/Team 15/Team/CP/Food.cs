using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// GameObject.Find("nameOfObjectYourScriptIsOn").GetComponent<move>().speed
public class Food : MonoBehaviour
{
    ElapsedTime timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("TimerObject").GetComponent<ElapsedTime>();
    
    }

    // Update is called once per frame
    void Update()
    {
        print(timer.time);
        // multiply by movespeed? increase like quadratic function tho?
        transform.position = transform.position + new Vector3(0, -Time.deltaTime * (float) Math.Pow(timer.time, 2), 0);
    }
}
