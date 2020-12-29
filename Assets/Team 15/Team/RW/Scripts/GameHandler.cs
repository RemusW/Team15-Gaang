
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
            MinigameManager.Instance.PlaySound("tsuzumi");
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

        public void eatSound()
        {
            int rand = Random.Range(0, 4);
            switch (rand)
            {
                case 0:
                    MinigameManager.Instance.PlaySound("slurp");
                    break;
                case 1:
                    MinigameManager.Instance.PlaySound("lowChomp");
                    break;
                case 2:
                    MinigameManager.Instance.PlaySound("highChomp");
                    break;
                case 3:
                    MinigameManager.Instance.PlaySound("Mmm");
                    break;
            }
        }
    }
}
