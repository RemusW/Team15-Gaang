using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace t15
{
    public class plate : MonoBehaviour
    {
        private bool isBad;
        public Sprite[] foodItem;

        // Start is called before the first frame update
        void Start()
        {
            int rand = Random.Range(0, foodItem.Length - 1);
            GetComponent<SpriteRenderer>().sprite = foodItem[rand];
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            GameObject.Find("GameHandler").GetComponent<GameHandler>().incScore();
        }
    }
}