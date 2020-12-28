using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start() {
        sr = GetComponent<SpriteRenderer>();
    }
    
    // Update is called once per frame
    void Update() {

    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            print("A key was pressed");
            sr.flipX = false;
        } else if (Input.GetKeyDown(KeyCode.D)) {
            print("d key was pressed");
            sr.flipX = true;
        }
    }
}
