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
    private bool caughtFood = false;

    // Start is called before the first frame update
    void Start()
    {
        //grabZone = GameObject.Find("GRAB_ZONE");
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
            activeSwipeFrames--;
        } else {
            if (grabZone) {
                grabZone.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        float dir = Input.GetAxis("Horizontal");
        animController.SetFloat("dir", dir); 
        print(caughtFood);
        animController.SetBool("caughtFood", caughtFood); 

    }

    public void Swipe(int dir) {
        if (dir == 1) { // right
            //grabZone.transform.position = new Vector3(4.59f, 1f, -0.3847656f);
            grabZone = transform.GetChild(1).gameObject;
        } else { // left
            //grabZone.transform.position = new Vector3(-4.89f, 1f, -0.3847656f);
            grabZone = transform.GetChild(0).gameObject;
        }
        grabZone.GetComponent<BoxCollider2D>().enabled = true;
        activeSwipeFrames = 5;
    }

    public void Eat() {
        int rand = Random.Range(0, 2);
        print(rand);
        eatingSFX[rand].Play();
    }

    public void setCaughtFood(bool b) {
        caughtFood = b;
    }

    public void resetCaughtFood() {
        caughtFood = false;
    }
}
