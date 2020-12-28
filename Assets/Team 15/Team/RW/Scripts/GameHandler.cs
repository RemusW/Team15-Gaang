using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace t15
{
    public class GameHandler : MonoBehaviour
    {
        private int score = 0;

        // Start is called before the first frame update
        void Start()
        {
            MinigameManager.Instance.minigame.gameWin = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (score > 3)
            {
                if (!MinigameManager.Instance.minigame.gameWin)
                {
                    MinigameManager.Instance.minigame.gameWin = true;
                    MinigameManager.Instance.PlaySound("win");
                }
            }
        }

        void incScore()
        {
            score++;
        }
    }
}
