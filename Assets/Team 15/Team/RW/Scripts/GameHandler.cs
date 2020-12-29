using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace t15
{
    public class GameHandler : MonoBehaviour
    {
        //public Text scoreText;

        private int score = 0;

        // Start is called before the first frame update
        void Start()
        {
            MinigameManager.Instance.PlaySound("win");
            MinigameManager.Instance.minigame.gameWin = false;
            //scoreText.text = "loook";
        }

        // Update is called once per frame
        void Update()
        {
            if (score >= 3)
            {
                if (!MinigameManager.Instance.minigame.gameWin)
                {
                    MinigameManager.Instance.minigame.gameWin = true;
                    MinigameManager.Instance.PlaySound("Assets/Team 15/SFX/Team15-4.wav");
                }
            }
        }

        public void incScore()
        {
            Debug.Log(score);
            score++;
        }

        public void decScore()
        {
            score--;
        }
    }
}
