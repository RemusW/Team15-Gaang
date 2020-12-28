using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using t15;

public class PlayerController : MonoBehaviour
{
    private bool isFacingLeft = true;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !isFacingLeft)
        {
            gameObject.transform.Rotate(0, 180, 0);
            isFacingLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.D) && isFacingLeft)
        {
            gameObject.transform.Rotate(0, 180, 0);
            isFacingLeft = false;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Plate"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("destroy");
            //incScore();
        }
    }
}
