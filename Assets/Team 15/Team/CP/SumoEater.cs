using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumoEater : MonoBehaviour
{
    [SerializeField]
    private AudioSource lowChomp;
    [SerializeField]
    private AudioSource highChomp;
    [SerializeField]
    private AudioSource slurp;
    private AudioSource[] eatingSFX;
    private GameObject grabZone;
    private Animator animController;
    private int activeSwipeFrames = 0;
    // Start is called before the first frame update
    void Start()
    {
        eatingSFX = new AudioSource[3];
        eatingSFX[0] = lowChomp;
        eatingSFX[1] = highChomp;
        eatingSFX[2] = slurp;
        animController = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (activeSwipeFrames > 0) {
            print(grabZone.GetComponent<BoxCollider2D>().isTrigger);
            activeSwipeFrames--;
        } else {
            if (grabZone) {
                grabZone.GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }
        float dir = Input.GetAxis("Horizontal");
        animController.SetFloat("dir", dir); 


        bool caughtFood = true;
        animController.SetBool("caughtFood", caughtFood); 
    }

    public void Swipe(int dir) {
        if (dir == 1) { // right
            grabZone = GameObject.Find("GRABZONE_RIGHT");
        } else { // left
            grabZone = GameObject.Find("GRABZONE_LEFT");
        }
        grabZone.GetComponent<BoxCollider2D>().isTrigger = true;
        activeSwipeFrames = 5;
    }

    public void Eat() {
        int rand = Random.Range(0, 2);
        print(rand);
        eatingSFX[rand].Play();
    }
}
